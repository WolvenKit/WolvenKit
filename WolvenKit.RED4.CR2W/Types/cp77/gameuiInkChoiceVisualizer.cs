using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInkChoiceVisualizer : gameuiIChoiceVisualizer
	{
		private CBool _isDynamic;
		private CEnum<gameuiChoiceListVisualizerType> _type;

		[Ordinal(0)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetProperty(ref _isDynamic);
			set => SetProperty(ref _isDynamic, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameuiChoiceListVisualizerType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public gameuiInkChoiceVisualizer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
