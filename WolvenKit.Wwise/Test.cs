using System;
using System.IO;
using WolvenKit.Wwise.Wwise;

namespace WolvenKit.Wwise
{
    internal static class Program
    {
        #region Methods

        [STAThread]
        private static void Main(string[] args)
        {
            int mode = -1;
            string bnk = "";
            string wem = "";
            int wid = -1;
            string folder = "";
            int playlist_id = -1;

            int argc = args.Length;
            if (argc < 2)
                show_usage();

            bnk = args[1];

            // preparing
            if (args[0] == "--merge-headers" || args[0] == "--music" || args[0] == "add-new-music" || args[0] == "--playlist-id-from-track" || args[0] == "--export-playlist" || args[0] == "reimport-playlist")
            {
                if (argc != 3)
                {
                    show_usage();
                }
            }
            else
            {
                if (args[0] == "--cue")
                {
                    Console.WriteLine("Entering mode: cue given wav");
                    var wav = args[1];
                    if (string.IsNullOrEmpty(wav))
                    {
                        Console.WriteLine("Invalid .wem file");
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Reading WAVE...");
                    var wavinput = new WemFile();
                    wavinput.LoadFromFile(wav, WwAudioFileType.Wav);
                    Console.WriteLine("Done.\n");
                    Console.WriteLine("Preparing WAVE...");
                    wavinput.Generate();
                    wavinput.Calculate_Riff_Size();
                    wavinput.WriteToFile(wav + ".cued");
                    Console.WriteLine("Done.");
                }
                else if (argc != 2)
                {
                    show_usage();
                }
            }

            if (args[0] == "--merge-headers")
            {
                if (argc != 3)
                    show_usage();
                var of = args[1];
                var mf = args[2];
                Console.WriteLine("Original file: " + of);
                Console.WriteLine("Modified file: " + mf);

                var input = new WemFile();
                input.LoadFromFile(of, WwAudioFileType.Wem);
                var output = new WemFile();
                output.LoadFromFile(mf, WwAudioFileType.Wem);
                Console.WriteLine("Files loaded.");

                output.merge_headers(input);
                output.Merge_Datas(input);
                output.Calculate_Riff_Size();
                output.WriteToFile(mf + ".wkitmerge");
                Console.WriteLine("Merging complete.");
            }
            else if (args[0] == "--music")
            {
                mode = Soundbank.MODE_BUILD_MUSIC;
                Console.WriteLine("Entering mode: Build music");
                wem = args[2];
                if (string.IsNullOrEmpty(wem))
                {
                    Console.WriteLine("Invalid .wem file.");
                    Environment.Exit(0);
                }
            }
            else if (args[0] == "--add-new-music")
            {
                mode = Soundbank.MODE_ADD_NEW_MUSIC;
                Console.WriteLine("Entering mode: Add new music");
                wem = args[2];
                if (string.IsNullOrEmpty(wem))
                {
                    Console.WriteLine("Invalid .wem file.");
                    Environment.Exit(0);
                }
            }
            else if (args[0] == "--playlist-id-from-track")
            {
                mode = Soundbank.MODE_PLAYLIST_ID;
                Console.WriteLine("Entering mode : Playlist from track");
                if (!int.TryParse(args[2], out wid))
                {
                    Console.WriteLine("ID not an integer.");
                    Environment.Exit(0);
                }
            }
            else if (args[0] == "--export-playlist")
            {
                mode = Soundbank.MODE_EXPORT_PLAYLIST;
                Console.WriteLine("Entering mode : Export playlist");
                if (!int.TryParse(args[2], out playlist_id))
                {
                    Console.WriteLine("Playlist ID not an integer.");
                    Environment.Exit(0);
                }
            }
            else if (args[0] == "--reimport-playlist")
            {
                mode = Soundbank.MODE_REIMPORT_PLAYLIST;
                Console.WriteLine("Entering mode: Reimport playlist");
                if (!int.TryParse(args[2], out playlist_id))
                {
                    Console.WriteLine("Playlist ID not an integer.");
                    Environment.Exit(0);
                }
            }
            else if (args[0] == "--debug")
            {
                mode = Soundbank.MODE_DEBUG;
                Console.WriteLine("Entering mode: Debug mode");
            }
            else
            {
                mode = Soundbank.MODE_BUILD;
                bnk = args[0];
                folder = args[1];
            }

            if (String.IsNullOrEmpty(bnk))
            {
                Console.WriteLine("Invalid .bnk file.");
                Environment.Exit(0);
            }
            Console.WriteLine("Sound bank file is: " + bnk);

            Console.WriteLine("Began reading sound bank.");
            Console.WriteLine("----------------------------------");
            Soundbank bank = new Soundbank(bnk);
            bank.readFile();
            Console.WriteLine("Reading sound bank done.");

            if (mode == Soundbank.MODE_DEBUG)
            {
                // checked
                Console.WriteLine("");
                bank.debugSound();
            }
            else if (mode == Soundbank.MODE_BUILD_MUSIC)
            {
                Console.WriteLine("Rebuilding new music...");
                bank.rebuild_music(wem);
                bank.build_bnk(bnk + ".rebuilt");
            }
            else if (mode == Soundbank.MODE_ADD_NEW_MUSIC)
            {
                Console.WriteLine("Adding new music...");
            }
            else if (mode == Soundbank.MODE_PLAYLIST_ID)
            {
                // checked
                if (wid != -1)
                {
                    Console.WriteLine("Extracting playlist...");
                    bank.get_playlist_ids((uint)wid);
                }
            }
            else if (mode == Soundbank.MODE_EXPORT_PLAYLIST)
            {
                // checked
                if (playlist_id != -1)
                {
                    Console.WriteLine("Exporting playlist...");
                    bank.export_playlist((uint)playlist_id);
                    Console.WriteLine("Done.");
                }
            }
            else if (mode == Soundbank.MODE_REIMPORT_PLAYLIST)
            {
                if (playlist_id != -1)
                {
                    Console.WriteLine("Reimporting playlist...");
                    bank.reimport_playlist((uint)playlist_id);
                    bank.build_bnk(bnk + ".rebuilt");
                    Console.WriteLine("Done.");
                }
            }
            else
            {
                if (bank._dataIndex == null || !bank._dataIndex._isSet)
                {
                    Console.WriteLine("Sound bank does not contain embedded files.");
                }
                Console.WriteLine("Rebuilding sounds...");
                bank.read_wems(folder);
                bank.rebuild_data();
                if (File.Exists(bnk + ".rebuilt"))
                    File.Delete(bnk + ".rebuilt");
                bank.build_bnk(bnk + ".rebuilt");
                Console.WriteLine("Done.");
            }
        }

        private static void show_usage()
        {
            string s = AppDomain.CurrentDomain.FriendlyName;
            Console.WriteLine("Usage: " + s + " <BNK> <FOLDER>");
            Console.WriteLine("Usage: " + s + " --music <BNK> <WEM>");
            Console.WriteLine("Usage: " + s + " --playlist-id-from-track <BNK> <TRACK ID>");
            Console.WriteLine("Usage: " + s + " --export-playlist <BNK> <PLAYLIST ID>");
            Console.WriteLine("Usage: " + s + " --reimport-playlist <BNK> <PLAYLIST ID>");
            Console.WriteLine("Usage: " + s + " --debug <BNK>");
            Console.WriteLine("Usage: " + s + " --cue <WAV>");
            Console.WriteLine("Usage: " + s + " --merge-headers <ORIGINAL WEM> <MODIFIED WEM>");
            Environment.Exit(0);
        }

        #endregion Methods
    }
}
