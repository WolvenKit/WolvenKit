using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBorderWidget : inkLeafWidget
	{
		[Ordinal(20)] [RED("thickness")] public CFloat Thickness { get; set; }

		public inkBorderWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
