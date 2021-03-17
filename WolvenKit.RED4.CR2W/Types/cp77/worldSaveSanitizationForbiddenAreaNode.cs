using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSaveSanitizationForbiddenAreaNode : worldTriggerAreaNode
	{
		private Vector4 _safeSpotOffset;

		[Ordinal(7)] 
		[RED("safeSpotOffset")] 
		public Vector4 SafeSpotOffset
		{
			get => GetProperty(ref _safeSpotOffset);
			set => SetProperty(ref _safeSpotOffset, value);
		}

		public worldSaveSanitizationForbiddenAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
