using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class RED4EnumTests
    {
        // Bitfields are stored by member name, so two members with one value make a read and write change the
        // bits: worlduiContextVisibility's 1 << 32 and 1 << 40 were int shifts, and SceneTier4 and SceneTier5
        // equalled SceneDefault and SceneTier1.
        [TestMethod]
        public void FlagsEnumMembersHaveDistinctValues()
        {
            var flagsEnums = typeof(Enums).GetNestedTypes()
                .Where(t => t.IsEnum && t.GetCustomAttribute<FlagsAttribute>() != null);

            foreach (var type in flagsEnums)
            {
                var shared = Enum.GetNames(type)
                    .GroupBy(name => Enum.Parse(type, name))
                    .Where(g => g.Count() > 1)
                    .Select(g => string.Join(" = ", g))
                    .ToList();

                Assert.AreEqual(0, shared.Count, $"{type.Name}: {string.Join("; ", shared)}");
            }
        }

        [TestMethod]
        [DataRow(Enums.worlduiContextVisibility.SceneDefault, 0)]
        [DataRow(Enums.worlduiContextVisibility.SceneTier1, 8)]
        [DataRow(Enums.worlduiContextVisibility.SceneTier2, 16)]
        [DataRow(Enums.worlduiContextVisibility.SceneTier3, 24)]
        [DataRow(Enums.worlduiContextVisibility.SceneTier4, 32)]
        [DataRow(Enums.worlduiContextVisibility.SceneTier5, 40)]
        public void WorlduiContextVisibilityBits(Enums.worlduiContextVisibility value, int bit) =>
            Assert.AreEqual(1L << bit, (long)value);
    }
}
