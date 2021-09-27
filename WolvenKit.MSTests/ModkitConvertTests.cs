//#define IS_PARALLEL
#define WRITE

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Tools;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.MSTests
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
        public void Read_bin() => Test_Extension(".bin");



        [TestMethod]
        public void Read_acousticdata() => Test_Extension(".acousticdata");

        [TestMethod]
        public void Read_actionanimdb() => Test_Extension(".actionanimdb");

        [TestMethod]
        public void Read_aiarch() => Test_Extension(".aiarch");

        [TestMethod]
        public void Read_animgraph() => Test_Extension(".animgraph");

        [TestMethod]
        public void Read_anims() => Test_Extension(".anims");

        [TestMethod]
        public void Read_app() => Test_Extension(".app");

        [TestMethod]
        public void Read_archetypes() => Test_Extension(".archetypes");

        [TestMethod]
        public void Read_areas() => Test_Extension(".areas");

        [TestMethod]
        public void Read_audio_metadata() => Test_Extension(".audio_metadata");

        [TestMethod]
        public void Read_audiovehcurveset() => Test_Extension(".audiovehcurveset");

        [TestMethod]
        public void Read_behavior() => Test_Extension(".behavior");

        [TestMethod]
        public void Read_bikecurveset() => Test_Extension(".bikecurveset");

        [TestMethod]
        public void Read_bk2() => Test_Extension(".bk2");

        [TestMethod]
        public void Read_bnk() => Test_Extension(".bnk");

        [TestMethod]
        public void Read_camcurveset() => Test_Extension(".camcurveset");

        [TestMethod]
        public void Read_cfoliage() => Test_Extension(".cfoliage");

        [TestMethod]
        public void Read_charcustpreset() => Test_Extension(".charcustpreset");

        [TestMethod]
        public void Read_cminimap() => Test_Extension(".cminimap");

        [TestMethod]
        public void Read_community() => Test_Extension(".community");

        [TestMethod]
        public void Read_conversations() => Test_Extension(".conversations");

        [TestMethod]
        public void Read_cooked_mlsetup() => Test_Extension(".cooked_mlsetup");

        [TestMethod]
        public void Read_cookedanims() => Test_Extension(".cookedanims");

        [TestMethod]
        public void Read_cookedapp() => Test_Extension(".cookedapp");

        [TestMethod]
        public void Read_credits() => Test_Extension(".credits");

        [TestMethod]
        public void Read_csv() => Test_Extension(".csv");

        [TestMethod]
        public void Read_cubemap() => Test_Extension(".cubemap");

        [TestMethod]
        public void Read_curveresset() => Test_Extension(".curveresset");

        [TestMethod]
        public void Read_curveset() => Test_Extension(".curveset");

        [TestMethod]
        public void Read_dat() => Test_Extension(".dat");

        [TestMethod]
        public void Read_devices() => Test_Extension(".devices");

        [TestMethod]
        public void Read_dtex() => Test_Extension(".dtex");

        [TestMethod]
        public void Read_effect() => Test_Extension(".effect");

        [TestMethod]
        public void Read_ent() => Test_Extension(".ent");

        [TestMethod]
        public void Read_env() => Test_Extension(".env");

        [TestMethod]
        public void Read_envparam() => Test_Extension(".envparam");

        [TestMethod]
        public void Read_envprobe() => Test_Extension(".envprobe");

        [TestMethod]
        public void Read_es() => Test_Extension(".es");

        [TestMethod]
        public void Read_facialcustom() => Test_Extension(".facialcustom");

        [TestMethod]
        public void Read_facialsetup() => Test_Extension(".facialsetup");

        [TestMethod]
        public void Read_fb2tl() => Test_Extension(".fb2tl");

        [TestMethod]
        public void Read_fnt() => Test_Extension(".fnt");

        [TestMethod]
        public void Read_folbrush() => Test_Extension(".folbrush");

        [TestMethod]
        public void Read_foldest() => Test_Extension(".foldest");

        [TestMethod]
        public void Read_fp() => Test_Extension(".fp");

        [TestMethod]
        public void Read_gamed() => Test_Extension(".game");

        [TestMethod]
        public void Read_gamedef() => Test_Extension(".gamedef");

        [TestMethod]
        public void Read_garmentlayerparams() => Test_Extension(".garmentlayerparams");

        [TestMethod]
        public void Read_genericanimdb() => Test_Extension(".genericanimdb");

        [TestMethod]
        public void Read_geometry_cache() => Test_Extension(".geometry_cache");

        [TestMethod]
        public void Read_gidata() => Test_Extension(".gidata");

        [TestMethod]
        public void Read_gradient() => Test_Extension(".gradient");

        [TestMethod]
        public void Read_hitrepresentation() => Test_Extension(".hitrepresentation");

        [TestMethod]
        public void Read_hp() => Test_Extension(".hp");

        [TestMethod]
        public void Read_ies() => Test_Extension(".ies");

        [TestMethod]
        public void Read_inkanim() => Test_Extension(".inkanim");

        [TestMethod]
        public void Read_inkatlas() => Test_Extension(".inkatlas");

        [TestMethod]
        public void Read_inkcharcustomization() => Test_Extension(".inkcharcustomization");

        [TestMethod]
        public void Read_inkfontfamily() => Test_Extension(".inkfontfamily");

        [TestMethod]
        public void Read_inkfullscreencomposition() => Test_Extension(".inkfullscreencomposition");

        [TestMethod]
        public void Read_inkgamesettings() => Test_Extension(".inkgamesettings");

        [TestMethod]
        public void Read_inkhud() => Test_Extension(".inkhud");

        [TestMethod]
        public void Read_inklayers() => Test_Extension(".inklayers");

        [TestMethod]
        public void Read_inkmenu() => Test_Extension(".inkmenu");

        [TestMethod]
        public void Read_inkshapecollection() => Test_Extension(".inkshapecollection");

        [TestMethod]
        public void Read_inkstyle() => Test_Extension(".inkstyle");

        [TestMethod]
        public void Read_inktypography() => Test_Extension(".inktypography");

        [TestMethod]
        public void Read_inkwidget() => Test_Extension(".inkwidget");

        [TestMethod]
        public void Read_interaction() => Test_Extension(".interaction");

        [TestMethod]
        public void Read_journal() => Test_Extension(".journal");

        [TestMethod]
        public void Read_journaldesc() => Test_Extension(".journaldesc");

        [TestMethod]
        public void Read_json() => Test_Extension(".json");

        [TestMethod]
        public void Read_lane_connections() => Test_Extension(".lane_connections");

        [TestMethod]
        public void Read_lane_polygons() => Test_Extension(".lane_polygons");

        [TestMethod]
        public void Read_lane_spots() => Test_Extension(".lane_spots");

        [TestMethod]
        public void Read_lights() => Test_Extension(".lights");

        [TestMethod]
        public void Read_lipmap() => Test_Extension(".lipmap");

        [TestMethod]
        public void Read_location() => Test_Extension(".location");

        [TestMethod]
        public void Read_locopaths() => Test_Extension(".locopaths");

        [TestMethod]
        public void Read_loot() => Test_Extension(".loot");

        [TestMethod]
        public void Read_mappins() => Test_Extension(".mappins");

        [TestMethod]
        public void Read_matlib() => Test_Extension(".matlib");

        [TestMethod]
        public void Read_mesh() => Test_Extension(".mesh");

        [TestMethod]
        public void Read_mi() => Test_Extension(".mi");

        [TestMethod]
        public void Read_mlmask() => Test_Extension(".mlmask");

        [TestMethod]
        public void Read_mlsetup() => Test_Extension(".mlsetup");

        [TestMethod]
        public void Read_mltemplate() => Test_Extension(".mltemplate");

        [TestMethod]
        public void Read_morphtarget() => Test_Extension(".morphtarget");

        [TestMethod]
        public void Read_mt() => Test_Extension(".mt");

        // removed in 1.3
        //[TestMethod]
        //public void Read_navmesh() => Test_Extension(".navmesh");

        [TestMethod]
        public void Read_null_areas() => Test_Extension(".null_areas");

        [TestMethod]
        public void Read_opusinfo() => Test_Extension(".opusinfo");

        [TestMethod]
        public void Read_opuspak() => Test_Extension(".opuspak");

        [TestMethod]
        public void Read_particle() => Test_Extension(".particle");

        [TestMethod]
        public void Read_phys() => Test_Extension(".phys");

        [TestMethod]
        public void Read_physicalscene() => Test_Extension(".physicalscene");

        [TestMethod]
        public void Read_physmatlib() => Test_Extension(".physmatlib");

        [TestMethod]
        public void Read_poimappins() => Test_Extension(".poimappins");

        [TestMethod]
        public void Read_psrep() => Test_Extension(".psrep");

        [TestMethod]
        public void Read_quest() => Test_Extension(".quest");

        [TestMethod]
        public void Read_questphase() => Test_Extension(".questphase");

        [TestMethod]
        public void Read_regionset() => Test_Extension(".regionset");

        [TestMethod]
        public void Read_remt() => Test_Extension(".remt");

        [TestMethod]
        public void Read_reps() => Test_Extension(".reps");

        [TestMethod]
        public void Read_reslist() => Test_Extension(".reslist");

        [TestMethod]
        public void Read_rig() => Test_Extension(".rig");

        [TestMethod]
        public void Read_scene() => Test_Extension(".scene");

        [TestMethod]
        public void Read_scenerid() => Test_Extension(".scenerid");

        [TestMethod]
        public void Read_scenesversions() => Test_Extension(".scenesversions");

        [TestMethod]
        public void Read_smartobject() => Test_Extension(".smartobject");

        [TestMethod]
        public void Read_smartobjects() => Test_Extension(".smartobjects");

        [TestMethod]
        public void Read_sp() => Test_Extension(".sp");

        [TestMethod]
        public void Read_spatial_representation() => Test_Extension(".spatial_representation");

        // removed in 1.3
        //[TestMethod]
        //public void Read_streamingquerydata() => Test_Extension(".streamingquerydata");

        [TestMethod]
        public void Read_streamingsector() => Test_Extension(".streamingsector");

        [TestMethod]
        public void Read_streamingsector_inplace() => Test_Extension(".streamingsector_inplace");

        [TestMethod]
        public void Read_streamingworld() => Test_Extension(".streamingworld");

        [TestMethod]
        public void Read_terrainsetup() => Test_Extension(".terrainsetup");

        [TestMethod]
        public void Read_texarray() => Test_Extension(".texarray");

        [TestMethod]
        public void Read_traffic_collisions() => Test_Extension(".traffic_collisions");

        [TestMethod]
        public void Read_traffic_persistent() => Test_Extension(".traffic_persistent");

        [TestMethod]
        public void Read_vehcommoncurveset() => Test_Extension(".vehcommoncurveset");

        [TestMethod]
        public void Read_vehcurveset() => Test_Extension(".vehcurveset");

        [TestMethod]
        public void Read_voicetags() => Test_Extension(".voicetags");

        [TestMethod]
        public void Read_w2mesh() => Test_Extension(".w2mesh");

        [TestMethod]
        public void Read_w2mi() => Test_Extension(".w2mi");

        [TestMethod]
        public void Read_wem() => Test_Extension(".wem");

        [TestMethod]
        public void Read_workspot() => Test_Extension(".workspot");

        [TestMethod]
        public void Read_xbm() => Test_Extension(".xbm");

        [TestMethod]
        public void Read_xcube() => Test_Extension(".xcube");

        #endregion test methods

        private static void Test_Extension(string extension)
        {
            var parsers = ServiceLocator.Default.ResolveType<Red4ParserService>();

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            var results = new ConcurrentBag<ArchiveTestResult>();
            var files = s_groupedFiles[extension].ToList();

#if IS_PARALLEL
            Parallel.ForEach(files, file =>
#else
            foreach (var file in files)
#endif
            {
                var hash = file.Key;
                var archive = file.Archive as Archive;

                try
                {
#region convert to json
                    using var originalMemoryStream = new MemoryStream();
                    ModTools.ExtractSingleToStream(archive, hash, originalMemoryStream);
                    var originalFile = parsers.TryReadCr2WFile(originalMemoryStream);
                    if (originalFile == null)
                    {
#if IS_PARALLEL
                        return;
#else
                        continue;
#endif
                    }

                    var dto = new Red4W2rcFileDto(originalFile);
                    var json = JsonConvert.SerializeObject(dto, Formatting.Indented);

                    //Assert.Equals(string.IsNullOrEmpty(json), false);
                    if (string.IsNullOrEmpty(json))
                    {
                        throw new SerializationException();
                    }

#endregion

#region convert back from json

                    var newdto = JsonConvert.DeserializeObject<Red4W2rcFileDto>(json);
                    //Assert.IsNotNull(newdto);
                    if (newdto == null)
                    {
                        throw new SerializationException();
                    }

                    var newFile = newdto.ToW2rc();

                    #endregion

                    #region compare

                    // old file
                    var header = (originalFile as CR2WFile).Header;
                    var objectsend = (int)header.objectsEnd;
                    var originalBytes = originalMemoryStream.ToByteArray().Take(objectsend);
                    var originalExportStartOffset = (int)originalFile.Chunks.FirstOrDefault().GetOffset();

                    // write the new file
                    using var newMemoryStream = new MemoryStream();
                    using var bw = new BinaryWriter(newMemoryStream);
                    newFile.Write(bw);

                    // hack to compare buffers
                    var newBytes = newMemoryStream.ToByteArray();

                    newMemoryStream.Seek(0, SeekOrigin.Begin);
                    var dbg = parsers.TryReadCr2WFileHeaders(newMemoryStream);
                    var newExportStartOffset = (int)dbg.Chunks.FirstOrDefault().GetOffset();





                    if (!originalBytes.Skip(160).SequenceEqual(newBytes.Skip(160)))
                    {
                        // check again skipping the tables
                        if (originalExportStartOffset == newExportStartOffset)
                        {
                            if (!originalBytes.Skip(originalExportStartOffset).SequenceEqual(newBytes.Skip(newExportStartOffset)))
                            {
#if WRITE
                                File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.o.bin"), originalBytes.ToArray());
                                File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.bin"), newBytes.ToArray());
#endif
                                throw new SerializationException();
                            }
                            else
                            {

                            }
                        }
                        else
                        {
#if WRITE
                            File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.o.bin"), originalBytes.ToArray());
                            File.WriteAllBytes(Path.Combine(resultDir, $"{file.Key}.bin"), newBytes.ToArray());
#endif
                            throw new SerializationException();
                        }


                        
                    }
                    else
                    {

                    }

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
