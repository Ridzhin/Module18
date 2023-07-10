using Module18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    class DownloadVideoCommand : ICommand
    {
        VideoPlayer videoPlayer;
        public DownloadVideoCommand(VideoPlayer videoPlayer)
        {
            this.videoPlayer = videoPlayer;
        }
        public async Task ExecuteAsync()
        {
            await videoPlayer.DownloadVideoAsync();
        }
    }
}