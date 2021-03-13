using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneWaveformGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("measurementsIntreval")] public CFloat MeasurementsIntreval { get; set; }
		[Ordinal(3)] [RED("measurementsCount")] public CInt32 MeasurementsCount { get; set; }
		[Ordinal(4)] [RED("barItemName")] public CName BarItemName { get; set; }
		[Ordinal(5)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(6)] [RED("bars")] public CArray<wCHandle<inkWidget>> Bars { get; set; }
		[Ordinal(7)] [RED("traces")] public CArray<wCHandle<inkWidget>> Traces { get; set; }
		[Ordinal(8)] [RED("cachedRootSize")] public Vector2 CachedRootSize { get; set; }
		[Ordinal(9)] [RED("maxValue")] public CFloat MaxValue { get; set; }
		[Ordinal(10)] [RED("barsPadding")] public CFloat BarsPadding { get; set; }
		[Ordinal(11)] [RED("barSize")] public Vector2 BarSize { get; set; }

		public gameuiPhoneWaveformGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
