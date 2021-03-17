using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleNpcOcclusionMetadata : audioEmitterMetadata
	{
		private CBool _void;

		[Ordinal(1)] 
		[RED("void")] 
		public CBool Void
		{
			get => GetProperty(ref _void);
			set => SetProperty(ref _void, value);
		}

		public audioVehicleNpcOcclusionMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
