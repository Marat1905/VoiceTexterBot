using FFMpegCore;
using VoiceTexterBot.BotConsole.Extensions;

namespace VoiceTexterBot.BotConsole.Utilities
{
    public static class AudioConverter
    {
        public static void TryConvert(string inputFile, string outputFile)
        {
            var f = DirectoryExtension.GetSolutionRoot();
            // Задаём путь, где лежит вспомогательная программа - конвертер
            GlobalFFOptions.Configure(options => options.BinaryFolder = Path.Combine(DirectoryExtension.GetSolutionRoot(), "ffmpeg-win64", "bin"));

            // Вызываем Ffmpeg, передав требуемые аргументы.
            FFMpegArguments
              .FromFileInput(inputFile)
              .OutputToFile(outputFile, true, options => options
                .WithFastStart())
              .ProcessSynchronously();
        }
    }
}
