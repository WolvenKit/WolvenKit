using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes : redEvent
	{
		private Vector4 _scaleMultiplier;

		[Ordinal(0)] 
		[RED("scaleMultiplier")] 
		public Vector4 ScaleMultiplier
		{
			get => GetProperty(ref _scaleMultiplier);
			set => SetProperty(ref _scaleMultiplier, value);
		}

		public gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
