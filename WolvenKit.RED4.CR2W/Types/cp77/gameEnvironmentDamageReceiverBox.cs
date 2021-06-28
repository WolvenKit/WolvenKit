using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverBox : gameEnvironmentDamageReceiverShape
	{
		private Vector3 _dimensions;

		[Ordinal(1)] 
		[RED("dimensions")] 
		public Vector3 Dimensions
		{
			get => GetProperty(ref _dimensions);
			set => SetProperty(ref _dimensions, value);
		}

		public gameEnvironmentDamageReceiverBox(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
