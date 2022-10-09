# Import libraries
import numpy as np
import pandas as pd
import pprint
# Get markov edges
def get_markov_edges(df):
    # Create a dictionary
    edges = {}
    # Loop columns
    for column in df.columns:
        # Loop rows
        for row in df.index:
            edges[(row,column)] = df.loc[row,column]
    # Return edges
    return edges
# Viterbi algorithm 
def viterbi(pi, a, b, obs):
    
    nStates = np.shape(b)[0]
    T = np.shape(obs)[0]
    
    path = np.zeros(T)
    delta = np.zeros((nStates, T))
    phi = np.zeros((nStates, T))
    
    delta[:, 0] = pi * b[:, obs[0]]
    phi[:, 0] = 0
    for t in range(1, T):
        for s in range(nStates):
            delta[s, t] = np.max(delta[:, t-1] * a[:, s]) * b[s, obs[t]] 
            phi[s, t] = np.argmax(delta[:, t-1] * a[:, s])
    
    path[T-1] = np.argmax(delta[:, T-1])
    for t in range(T-2, -1, -1):
        path[t] = phi[int(path[t+1]),int(t+1)]
    return path, delta
# The main entry point for this module
def main():
    # Observation states
    observation_states = ['A', 'G','C', 'T']
    # Create hidden states with probabilities
    p = [0.6,0.4]
    hidden_states = ['a', 'b']
    state_space = pd.Series(p, index=hidden_states, name='states')
    # Print hidden states
    print('--- Hidden states ---')
    print(state_space)
    print()
    # Create a hidden states transition matrix with probabilities
    hidden_df = pd.DataFrame(columns=hidden_states, index=hidden_states)
    hidden_df.loc[hidden_states[0]] = [0.9,0.1]
    hidden_df.loc[hidden_states[1]] = [0.1,0.9]
    # Print transition matrix
    print('--- Transition matrix for hidden states ---')
    print(hidden_df)
    print()
    print(hidden_df.sum(axis=1))
    print()
    # Create matrix of observations with sensor probabilities
    observations_df = pd.DataFrame(columns=observation_states, index=hidden_states)
    observations_df.loc[hidden_states[0]] = [0.4,0.4,0.1,0.1]
    observations_df.loc[hidden_states[1]] = [0.2,0.2,0.3,0.3]
    # Print observation matrix
    print('--- Sensor matrix ---')
    print(observations_df)
    print()
    print(observations_df.sum(axis=1))
    print()
    # Create graph edges and weights
    hidden_edges = get_markov_edges(hidden_df)
    observation_edges = get_markov_edges(observations_df)
    # Print edges
    print('--- Hidden edges ---')
    pprint.pprint(hidden_edges)
    print()
    print('--- Sensor edges ---')
    pprint.pprint(observation_edges)
    print()
    # Observations
    observations_map = {0:'A', 1:'G', 2:'C', 3:'T'}
    observations = np.array([1,1,2,3])
    observerations_path = [observations_map[v] for v in list(observations)]
    # Get predictions with the viterbi algorithm
    path, delta= viterbi(p, hidden_df.values, observations_df.values, observations)
    state_map = {0:'a', 1:'b'}
    state_path = [state_map[v] for v in path]
    state_delta = np.amax(delta, axis=0)
    # Print predictions
    print('--- Predictions ---')
    print(pd.DataFrame().assign(Observation=observerations_path).assign(Prediction=state_path).assign(Delta=state_delta))
    print()
# run main method
if __name__ == "__main__": main()