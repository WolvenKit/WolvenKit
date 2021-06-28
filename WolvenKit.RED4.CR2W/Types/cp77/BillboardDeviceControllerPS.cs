using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BillboardDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CName _glitchSFX;
		private CBool _useLights;
		private CArray<EditableGameLightSettings> _lightsSettings;
		private CBool _useDeviceAppearence;

		[Ordinal(103)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetProperty(ref _glitchSFX);
			set => SetProperty(ref _glitchSFX, value);
		}

		[Ordinal(104)] 
		[RED("useLights")] 
		public CBool UseLights
		{
			get => GetProperty(ref _useLights);
			set => SetProperty(ref _useLights, value);
		}

		[Ordinal(105)] 
		[RED("lightsSettings")] 
		public CArray<EditableGameLightSettings> LightsSettings
		{
			get => GetProperty(ref _lightsSettings);
			set => SetProperty(ref _lightsSettings, value);
		}

		[Ordinal(106)] 
		[RED("useDeviceAppearence")] 
		public CBool UseDeviceAppearence
		{
			get => GetProperty(ref _useDeviceAppearence);
			set => SetProperty(ref _useDeviceAppearence, value);
		}

		public BillboardDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
