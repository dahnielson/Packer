# Packer

Packer is a simple Windows tool used to pack grey scale images into RGBA channels.

## How to use

Each channel in the final image has a slot marked R, G, B and A respectively. Drag a grey scale image and drop it on the slot you want to assign it to. Click on the "Save As.." button to save the packed image. You need to assign atleast one image to a channel to be able to save, unassigned channels will contain default values of 0 for the color channels and 255 for the alpha channel.

While it is recommended you pack images of the same dimensions, it is possible to images of different dimensions, however the smaller images will be poorly upsampled and stretched using nearest neighbor interpolation.

It is also possible to drop color images on the channel slots. The corresponding channel in the color image will be used: the red channel if dropped on R, green channel if dropped on G, blue channel if dropped on B and alpha channel if dropped on A.

## What is a grey scale image?

Normally images containing either RGB or RGBA channels are considered color images, and images with only one channel are considered grey scale. But due to limitations of the Windows API, that convert all droped images to RGBA, whether a droped image is color or grey scale is determined by Packer by inspecting the channel content. Thus any image where the values for all three color channels are the same and the alpha channel is completely opaque is considered a grey scale image.
