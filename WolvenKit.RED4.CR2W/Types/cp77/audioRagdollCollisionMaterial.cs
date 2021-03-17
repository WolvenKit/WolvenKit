using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRagdollCollisionMaterial : audioAudioMetadata
	{
		private CName _lightCollisionEventName;
		private CName _heavyCollisionEventName;
		private CName _dismemberedLimbCollisionEventName;

		[Ordinal(1)] 
		[RED("lightCollisionEventName")] 
		public CName LightCollisionEventName
		{
			get => GetProperty(ref _lightCollisionEventName);
			set => SetProperty(ref _lightCollisionEventName, value);
		}

		[Ordinal(2)] 
		[RED("heavyCollisionEventName")] 
		public CName HeavyCollisionEventName
		{
			get => GetProperty(ref _heavyCollisionEventName);
			set => SetProperty(ref _heavyCollisionEventName, value);
		}

		[Ordinal(3)] 
		[RED("dismemberedLimbCollisionEventName")] 
		public CName DismemberedLimbCollisionEventName
		{
			get => GetProperty(ref _dismemberedLimbCollisionEventName);
			set => SetProperty(ref _dismemberedLimbCollisionEventName, value);
		}

		public audioRagdollCollisionMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
