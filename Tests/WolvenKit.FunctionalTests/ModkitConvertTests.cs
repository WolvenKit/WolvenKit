//#define WRITE
#define IS_PARALLEL

#if WRITE
#undef IS_PARALLEL
#endif

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.Conversion;
using WolvenKit.Core.Extensions;
using WolvenKit.FunctionalTests.Model;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;

namespace WolvenKit.FunctionalTests
{
    [TestClass]
    public class ModkitConvertTests : GameUnitTest
    {
        #region Methods

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        #endregion Methods

        #region test methods

        //[TestMethod]
        //public void Test_All_Extensions()
        //{
        //    Test_Extension();
        //}


        [TestMethod]
        public void Convert_bin() => Test_Extension(".bin");



        [TestMethod]
        public void Convert_acousticdata() => Test_Extension(".acousticdata");

        [TestMethod]
        public void Convert_actionanimdb() => Test_Extension(".actionanimdb");

        [TestMethod]
        public void Convert_aiarch() => Test_Extension(".aiarch");

        [TestMethod]
        public void Convert_animgraph() => Test_Extension(".animgraph");

        [TestMethod]
        public void Convert_anims() => Test_Extension(".anims");

        [TestMethod]
        public void Convert_app() => Test_Extension(".app");

        [TestMethod]
        public void Convert_archetypes() => Test_Extension(".archetypes");

        [TestMethod]
        public void Convert_areas() => Test_Extension(".areas");

        [TestMethod]
        public void Convert_audio_metadata() => Test_Extension(".audio_metadata");

        [TestMethod]
        public void Convert_audiovehcurveset() => Test_Extension(".audiovehcurveset");

        [TestMethod]
        public void Convert_behavior() => Test_Extension(".behavior");

        [TestMethod]
        public void Convert_bikecurveset() => Test_Extension(".bikecurveset");

        [TestMethod]
        public void Convert_bk2() => Test_Extension(".bk2");

        [TestMethod]
        public void Convert_bnk() => Test_Extension(".bnk");

        [TestMethod]
        public void Convert_camcurveset() => Test_Extension(".camcurveset");

        [TestMethod]
        public void Convert_ccstate() => Test_Extension(".ccstate");

        [TestMethod]
        public void Convert_cfoliage() => Test_Extension(".cfoliage");

        [TestMethod]
        public void Convert_charcustpreset() => Test_Extension(".charcustpreset");

        [TestMethod]
        public void Convert_cminimap() => Test_Extension(".cminimap");

        [TestMethod]
        public void Convert_community() => Test_Extension(".community");

        [TestMethod]
        public void Convert_conversations() => Test_Extension(".conversations");

        [TestMethod]
        public void Convert_cooked_mlsetup() => Test_Extension(".cooked_mlsetup");

        [TestMethod]
        public void Convert_cookedanims() => Test_Extension(".cookedanims");

        [TestMethod]
        public void Convert_cookedapp() => Test_Extension(".cookedapp");

        [TestMethod]
        public void Convert_credits() => Test_Extension(".credits");

        [TestMethod]
        public void Convert_csv() => Test_Extension(".csv");

        [TestMethod]
        public void Convert_cubemap() => Test_Extension(".cubemap");

        [TestMethod]
        public void Convert_curveresset() => Test_Extension(".curveresset");

        [TestMethod]
        public void Convert_curveset() => Test_Extension(".curveset");

        [TestMethod]
        public void Convert_dat() => Test_Extension(".dat");

        [TestMethod]
        public void Convert_devices() => Test_Extension(".devices");

        [TestMethod]
        public void Convert_dtex() => Test_Extension(".dtex");

        [TestMethod]
        public void Convert_effect() => Test_Extension(".effect");

        [TestMethod]
        public void Convert_ent() => Test_Extension(".ent");

        [TestMethod]
        public void Convert_env() => Test_Extension(".env");

        [TestMethod]
        public void Convert_envparam() => Test_Extension(".envparam");

        [TestMethod]
        public void Convert_envprobe() => Test_Extension(".envprobe");

        [TestMethod]
        public void Convert_es() => Test_Extension(".es");

        [TestMethod]
        public void Convert_facialcustom() => Test_Extension(".facialcustom");

        [TestMethod]
        public void Convert_facialsetup() => Test_Extension(".facialsetup");

        [TestMethod]
        public void Convert_fb2tl() => Test_Extension(".fb2tl");

        [TestMethod]
        public void Convert_fnt() => Test_Extension(".fnt");

        [TestMethod]
        public void Convert_folbrush() => Test_Extension(".folbrush");

        [TestMethod]
        public void Convert_foldest() => Test_Extension(".foldest");

        [TestMethod]
        public void Convert_fp() => Test_Extension(".fp");

        [TestMethod]
        public void Convert_gamed() => Test_Extension(".game");

        [TestMethod]
        public void Convert_gamedef() => Test_Extension(".gamedef");

        [TestMethod]
        public void Convert_garmentlayerparams() => Test_Extension(".garmentlayerparams");

        [TestMethod]
        public void Convert_genericanimdb() => Test_Extension(".genericanimdb");

        [TestMethod]
        public void Convert_geometry_cache() => Test_Extension(".geometry_cache");

        [TestMethod]
        public void Convert_gidata() => Test_Extension(".gidata");

        [TestMethod]
        public void Convert_gradient() => Test_Extension(".gradient");

        [TestMethod]
        public void Convert_hitrepresentation() => Test_Extension(".hitrepresentation");

        [TestMethod]
        public void Convert_hp() => Test_Extension(".hp");

        [TestMethod]
        public void Convert_ies() => Test_Extension(".ies");

        [TestMethod]
        public void Convert_inkanim() => Test_Extension(".inkanim");

        [TestMethod]
        public void Convert_inkatlas() => Test_Extension(".inkatlas");

        [TestMethod]
        public void Convert_inkcharcustomization() => Test_Extension(".inkcharcustomization");

        [TestMethod]
        public void Convert_inkenginesettings() => Test_Extension(".inkenginesettings");

        [TestMethod]
        public void Convert_inkfontfamily() => Test_Extension(".inkfontfamily");

        [TestMethod]
        public void Convert_inkfullscreencomposition() => Test_Extension(".inkfullscreencomposition");

        [TestMethod]
        public void Convert_inkgamesettings() => Test_Extension(".inkgamesettings");

        [TestMethod]
        public void Convert_inkhud() => Test_Extension(".inkhud");

        [TestMethod]
        public void Convert_inklayers() => Test_Extension(".inklayers");

        [TestMethod]
        public void Convert_inkmenu() => Test_Extension(".inkmenu");

        [TestMethod]
        public void Convert_inkshapecollection() => Test_Extension(".inkshapecollection");

        [TestMethod]
        public void Convert_inkstyle() => Test_Extension(".inkstyle");

        [TestMethod]
        public void Convert_inktypography() => Test_Extension(".inktypography");

        [TestMethod]
        public void Convert_inkwidget() => Test_Extension(".inkwidget");

        [TestMethod]
        public void Convert_interaction() => Test_Extension(".interaction");

        [TestMethod]
        public void Convert_journal() => Test_Extension(".journal");

        [TestMethod]
        public void Convert_journaldesc() => Test_Extension(".journaldesc");

        [TestMethod]
        public void Convert_json() => Test_Extension(".json");

        [TestMethod]
        public void Convert_lane_connections() => Test_Extension(".lane_connections");

        [TestMethod]
        public void Convert_lane_polygons() => Test_Extension(".lane_polygons");

        [TestMethod]
        public void Convert_lane_spots() => Test_Extension(".lane_spots");

        [TestMethod]
        public void Convert_lights() => Test_Extension(".lights");

        [TestMethod]
        public void Convert_lipmap() => Test_Extension(".lipmap");

        [TestMethod]
        public void Convert_location() => Test_Extension(".location");

        [TestMethod]
        public void Convert_locopaths() => Test_Extension(".locopaths");

        [TestMethod]
        public void Convert_loot() => Test_Extension(".loot");

        [TestMethod]
        public void Convert_mappins() => Test_Extension(".mappins");

        [TestMethod]
        public void Convert_matlib() => Test_Extension(".matlib");

        [TestMethod]
        public void Convert_mesh() => Test_Extension(".mesh");

        [TestMethod]
        public void Convert_mi() => Test_Extension(".mi");

        [TestMethod]
        public void Convert_mlmask() => Test_Extension(".mlmask");

        [TestMethod]
        public void Convert_mlsetup() => Test_Extension(".mlsetup");

        [TestMethod]
        public void Convert_mltemplate() => Test_Extension(".mltemplate");

        [TestMethod]
        public void Convert_morphtarget() => Test_Extension(".morphtarget");

        [TestMethod]
        public void Convert_mt() => Test_Extension(".mt");

        // removed in 1.3
        //[TestMethod]
        //public void Convert_navmesh() => Test_Extension(".navmesh");

        [TestMethod]
        public void Convert_null_areas() => Test_Extension(".null_areas");

        [TestMethod]
        public void Convert_opusinfo() => Test_Extension(".opusinfo");

        [TestMethod]
        public void Convert_opuspak() => Test_Extension(".opuspak");

        [TestMethod]
        public void Convert_particle() => Test_Extension(".particle");

        [TestMethod]
        public void Convert_phys() => Test_Extension(".phys");

        [TestMethod]
        public void Convert_physicalscene() => Test_Extension(".physicalscene");

        [TestMethod]
        public void Convert_physmatlib() => Test_Extension(".physmatlib");

        [TestMethod]
        public void Convert_poimappins() => Test_Extension(".poimappins");

        [TestMethod]
        public void Convert_psrep() => Test_Extension(".psrep");

        [TestMethod]
        public void Convert_quest() => Test_Extension(".quest");

        [TestMethod]
        public void Convert_questphase() => Test_Extension(".questphase");

        [TestMethod]
        public void Convert_regionset() => Test_Extension(".regionset");

        [TestMethod]
        public void Convert_remt() => Test_Extension(".remt");

        [TestMethod]
        public void Convert_reps() => Test_Extension(".reps");

        [TestMethod]
        public void Convert_reslist() => Test_Extension(".reslist");

        [TestMethod]
        public void Convert_rig() => Test_Extension(".rig");

        [TestMethod]
        public void Convert_scene() => Test_Extension(".scene");

        [TestMethod]
        public void Convert_scenerid() => Test_Extension(".scenerid");

        [TestMethod]
        public void Convert_scenesversions() => Test_Extension(".scenesversions");

        [TestMethod]
        public void Convert_smartobject() => Test_Extension(".smartobject");

        [TestMethod]
        public void Convert_smartobjects() => Test_Extension(".smartobjects");

        [TestMethod]
        public void Convert_sp() => Test_Extension(".sp");

        [TestMethod]
        public void Convert_spatial_representation() => Test_Extension(".spatial_representation");

        [TestMethod]
        public void Convert_streamingquerydata() => Test_Extension(".streamingquerydata");

        [TestMethod]
        public void Convert_streamingblock() => Test_Extension(".streamingblock");

        [TestMethod]
        public void Convert_streamingsector() => Test_Extension(".streamingsector");

        [TestMethod]
        public void Convert_streamingsector_inplace() => Test_Extension(".streamingsector_inplace");

        [TestMethod]
        public void Convert_streamingworld() => Test_Extension(".streamingworld");

        [TestMethod]
        public void Convert_terrainsetup() => Test_Extension(".terrainsetup");

        [TestMethod]
        public void Convert_texarray() => Test_Extension(".texarray");

        [TestMethod]
        public void Convert_traffic_collisions() => Test_Extension(".traffic_collisions");

        [TestMethod]
        public void Convert_traffic_persistent() => Test_Extension(".traffic_persistent");

        [TestMethod]
        public void Convert_vehcommoncurveset() => Test_Extension(".vehcommoncurveset");

        [TestMethod]
        public void Convert_vehcurveset() => Test_Extension(".vehcurveset");

        [TestMethod]
        public void Convert_voicetags() => Test_Extension(".voicetags");

        [TestMethod]
        public void Convert_w2mesh() => Test_Extension(".w2mesh");

        [TestMethod]
        public void Convert_w2mi() => Test_Extension(".w2mi");

        [TestMethod]
        public void Convert_wem() => Test_Extension(".wem");

        [TestMethod]
        public void Convert_workspot() => Test_Extension(".workspot");

        [TestMethod]
        public void Convert_xbm() => Test_Extension(".xbm");

        [TestMethod]
        public void Convert_xcube() => Test_Extension(".xcube");

        #endregion test methods

        private static void Test_Extension(string extension)
        {
            var parsers = _host.Services.GetRequiredService<Red4ParserService>();

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);
            foreach (var file in Directory.GetFiles(resultDir))
            {
                File.Delete(file);
            }

            var results = new ConcurrentBag<ArchiveTestResult>();
            var files = s_groupedFiles[extension].ToList();

#if IS_PARALLEL
            Parallel.ForEach(files, file =>
#else
            foreach (var file in files)
#endif
            {
                var hash = file.Key;
                var archive = file.GetArchive<Archive>();
                ArgumentNullException.ThrowIfNull(archive);

                try
                {
                    #region convert to json
                    using var originalMemoryStream = new MemoryStream();
                    ModTools.ExtractSingleToStream(archive, hash, originalMemoryStream);
                    if (!parsers.TryReadRed4File(originalMemoryStream, out var originalFile))
                    {
#if IS_PARALLEL
                        return;
#else
                        continue;
#endif
                    }

                    var dto = new RedFileDto(originalFile);
                    var json = RedJsonSerializer.Serialize(dto);
                    if (string.IsNullOrEmpty(json))
                    {
                        throw new SerializationException();
                    }

                    #endregion

                    #region convert back from json

                    var newdto = RedJsonSerializer.Deserialize<RedFileDto>(json);
                    if (newdto == null)
                    {
                        throw new SerializationException();
                    }

                    var newFile = newdto.Data;

                    #endregion

                    #region compare

                    // old file
                    var header = originalFile.MetaData;
                    var objectsend = (int)header.ObjectsEnd;
                    var originalBytes = originalMemoryStream.ToByteArray().Take(objectsend);

                    // write the new file
                    using var newMemoryStream = new MemoryStream();
                    using var writer = new CR2WWriter(newMemoryStream);
                    writer.WriteFile(newFile);

                    // hack to compare buffers
                    var newBytes = newMemoryStream.ToByteArray();

                    newMemoryStream.Seek(0, SeekOrigin.Begin);
                    var dbg = parsers.ReadRed4File(newMemoryStream);
                    //var newExportStartOffset = (int)dbg.Chunks.FirstOrDefault().GetOffset();




                    //                    var originalExportStartOffset = (int)originalFile.Chunks.FirstOrDefault().GetOffset();
                    //                    if (!originalBytes.Skip(160).SequenceEqual(newBytes.Skip(160)))
                    //                    {
                    //                        // check again skipping the tables
                    //                        if (originalExportStartOffset == newExportStartOffset)
                    //                        {
                    //                            if (!originalBytes.Skip(originalExportStartOffset).SequenceEqual(newBytes.Skip(newExportStartOffset)))
                    //                            {
                    //#if WRITE
                    //                                File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.o.bin"), originalBytes.ToArray());
                    //                                File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.bin"), newBytes.ToArray());
                    //#endif
                    //                                throw new SerializationException("Exports not equal");
                    //                            }
                    //                            else
                    //                            {

                    //                            }
                    //                        }
                    //                        else
                    //                        {
                    //#if WRITE
                    //                            File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.o.bin"), originalBytes.ToArray());
                    //                            File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.bin"), newBytes.ToArray());
                    //#endif
                    //                            throw new SerializationException("Header not equal");
                    //                        }



                    //                    }
                    //                    else
                    //                    {

                    //                    }

                    #endregion

                    results.Add(new ArchiveTestResult()
                    {
                        ArchiveName = archive.Name,
                        Hash = hash.ToString(),
                        Success = true
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{hash} - {e.Message} - {e.StackTrace}");
                    results.Add(new ArchiveTestResult()
                    {
                        ArchiveName = archive.Name,
                        Hash = hash.ToString(),
                        Success = false,
                        ExceptionType = e.GetType(),
                        Message = $"{e.Message}"
                    });
                }
#if IS_PARALLEL
            });
#else
            }
#endif

            var totalCount = files.Count;

            // Check success
            var successCount = results.Count(r => r.Success);
            var sb = new StringBuilder();
            sb.AppendLine($"Successfully serialized: {successCount} / {totalCount} ({(int)(successCount / (double)totalCount * 100)}%)");
            var success = results.All(r => r.Success);
            if (success)
            {
                return;
            }

            var msg = $"Successful serialized: {successCount} / {totalCount}. ";
            Assert.Fail(msg);
        }
    }
}
