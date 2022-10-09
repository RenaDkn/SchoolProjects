workingDir = tempname;
mkdir(workingDir)
mkdir(workingDir,'images')
video = VideoReader('FallingApple.mp4');
ii=1;
while hasFrame(video)
   img = readFrame(video);
   filename = [sprintf('%03d',ii) '.jpg'];
   fullname = fullfile(workingDir,'images',filename);
   imwrite(img,fullname)
   ii = ii+1;
end
imageNames = dir(fullfile(workingDir,'images','*.jpg'));
imageNames = {imageNames.name}';

for ii = 1:length(imageNames)
   img = imread(fullfile(workingDir,'images',imageNames{ii}));
   fun = @(block_struct) imresize(block_struct.data,0.16);
   I2 = blockproc(img,[32 32],fun);
   imshow(I2);
end