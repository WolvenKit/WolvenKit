using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBorderWidget : inkLeafWidget
	{
		private CFloat _thickness;

		[Ordinal(20)] 
		[RED("thickness")] 
		public CFloat Thickness
		{
			get => GetProperty(ref _thickness);
			set => SetProperty(ref _thickness, value);
		}

		public inkBorderWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
