using NUnit.Framework;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Core.Tests;

public class HashStringWithoutAliasesTests
{
    private const ulong s_helloWorldHash = 14998808953798625955;
    private const ulong s_semicolonHash = 16982440701406162758;
    
    [Test]
    [TestCase("$/hello/world/12345")]
    [TestCase("$/#hello/world/12345")]
    public void Hasher_Should_Handle_Simple_Cases(string source)
    {
        var hash = FNV1A64HashAlgorithm.HashStringWithoutAliases(source);
        Assert.That(hash, Is.EqualTo(s_helloWorldHash));
    }

    [Test]
    [TestCase("$/test/important/123/456")]
    [TestCase("$/test/important;#alias/123/456")]
    public void Hasher_Should_Handle_Semicolon(string source)
    {
        var hash = FNV1A64HashAlgorithm.HashStringWithoutAliases(source);
        Assert.That(hash, Is.EqualTo(s_semicolonHash));
    }

    [Test]
    [TestCase("$/03_night_city/#c_city_center/#c_city_center_air_traffic", 13701749328974838295)]
    [TestCase("$/03_night_city/#c_city_center/#c_city_center_air_traffic/{air_traffic_av_line_mid_8_avs}_020_prefabQ5RFZPI/{air_traffic_mid_}_002_prefabSDVGHLQ", 5910196056938917739ul)]
    [TestCase("$/03_night_city/#c_city_center/#c_city_center_air_traffic/{air_traffic_av_line_mid_8_avs}_020_prefabQ5RFZPI/speedSpline", 1868123494098026698ul)]
    [TestCase("$/03_night_city/#c_city_center/corpo_plaza/#loc_arasaka_tower/#loc_arasaka_tower_env/interior_prefab5W2RVJA/q113_saburos_office_prefab3J25ZSA/{loc_q113_arasaka_rooftop_devices}_prefabWH2FUBQ/{q113_arasaka_offices_main_door_new}_prefab7RDD2FQ/{double_door_sliding_l}_prefabV6UV7YQ;#q113_arasaka_offices_main_door_new", 4886409109574024977ul)]
    [TestCase("$/03_night_city/#c_city_center/corpo_plaza/#loc_arasaka_tower/#loc_arasaka_tower_env/interior_prefab5W2RVJA/q113_saburos_office_prefab3J25ZSA/{loc_q113_arasaka_rooftop_devices}_prefabWH2FUBQ/lift_3_floors_prefab4PDNO3Y/{lift_door_}3_prefab7Y7O7ZI_005;#q113_06_saburo_office_hallway_elevator", 12677911292092322200)]
    [TestCase("$/03_night_city/#c_city_center/corpo_plaza/#loc_arasaka_tower/#loc_arasaka_tower_env/interior_prefab5W2RVJA/q113_saburos_office_prefab3J25ZSA/{loc_q113_arasaka_rooftop_devices}_prefabWH2FUBQ/single_door_5_prefabP56IZMY/door1;#q113_av_hangar_door", 987549654063553389ul)]
    public void Hasher_Should_Handle_Real_Life_Examples(string source, ulong expected)
    {
        var hash = FNV1A64HashAlgorithm.HashStringWithoutAliases(source);
        Assert.That(hash, Is.EqualTo(expected));
    }
}