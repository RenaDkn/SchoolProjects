workingDir = tempname;
mkdir(workingDir)
mkdir(workingDir,'images')
video = VideoReader('FallingApple.mp4');
ii = 1;
while hasFrame(video)
   img = readFrame(video);
   filename = [sprintf('%03d',ii) '.jpg'];
   fullname = fullfile(workingDir,'images',filename);
   imwrite(img,fullname)
   ii = ii+1;
end
imageNames = dir(fullfile(workingDir,'images','*.jpg'));
imageNames = {imageNames.name}';
outputVideo = VideoWriter(fullfile(workingDir,'FallingApple_out.avi'));
outputVideo.FrameRate = video.FrameRate;
open(outputVideo)
for ii = 1:length(imageNames)
   img = imread(fullfile(workingDir,'images',imageNames{ii}));
   writeVideo(outputVideo,img)
end
close(outputVideo)

video2 = VideoReader(fullfile(workingDir,'FallingApple_out.avi'));

ii = 1;
while hasFrame(video2)
   mov(ii) = im2frame(readFrame(video2));
   ii = ii+1;
end


figure 
imshow(mov(1).cdata, 'Border', 'tight')

movie(mov,1,video2.FrameRate)
jj = 1;
for ii = 1:length(imageNames)
   img1 = imread(fullfile(workingDir,'images',imageNames{ii}));
   jj = jj+1;
   img2 = imread(fullfile(workingDir,'images',imageNames{jj}));
   K = imabsdiff(img1,img2);
   imshow(K)
end
  
