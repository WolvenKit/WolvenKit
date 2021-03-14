using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEntitySettings : audioAudioMetadata
	{
		private audioCommonEntitySettings _commonSettings;
		private audioScanningSettings _scanningSettings;
		private audioAuxiliaryMetadata _auxiliaryMetadata;
		private CName _emitterDecoratorMetadata;
		private CBool _preferSoundComponentPosition;

		[Ordinal(1)] 
		[RED("commonSettings")] 
		public audioCommonEntitySettings CommonSettings
		{
			get
			{
				if (_commonSettings == null)
				{
					_commonSettings = (audioCommonEntitySettings) CR2WTypeManager.Create("audioCommonEntitySettings", "commonSettings", cr2w, this);
				}
				return _commonSettings;
			}
			set
			{
				if (_commonSettings == value)
				{
					return;
				}
				_commonSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scanningSettings")] 
		public audioScanningSettings ScanningSettings
		{
			get
			{
				if (_scanningSettings == null)
				{
					_scanningSettings = (audioScanningSettings) CR2WTypeManager.Create("audioScanningSettings", "scanningSettings", cr2w, this);
				}
				return _scanningSettings;
			}
			set
			{
				if (_scanningSettings == value)
				{
					return;
				}
				_scanningSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("auxiliaryMetadata")] 
		public audioAuxiliaryMetadata AuxiliaryMetadata
		{
			get
			{
				if (_auxiliaryMetadata == null)
				{
					_auxiliaryMetadata = (audioAuxiliaryMetadata) CR2WTypeManager.Create("audioAuxiliaryMetadata", "auxiliaryMetadata", cr2w, this);
				}
				return _auxiliaryMetadata;
			}
			set
			{
				if (_auxiliaryMetadata == value)
				{
					return;
				}
				_auxiliaryMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("emitterDecoratorMetadata")] 
		public CName EmitterDecoratorMetadata
		{
			get
			{
				if (_emitterDecoratorMetadata == null)
				{
					_emitterDecoratorMetadata = (CName) CR2WTypeManager.Create("CName", "emitterDecoratorMetadata", cr2w, this);
				}
				return _emitterDecoratorMetadata;
			}
			set
			{
				if (_emitterDecoratorMetadata == value)
				{
					return;
				}
				_emitterDecoratorMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("preferSoundComponentPosition")] 
		public CBool PreferSoundComponentPosition
		{
			get
			{
				if (_preferSoundComponentPosition == null)
				{
					_preferSoundComponentPosition = (CBool) CR2WTypeManager.Create("Bool", "preferSoundComponentPosition", cr2w, this);
				}
				return _preferSoundComponentPosition;
			}
			set
			{
				if (_preferSoundComponentPosition == value)
				{
					return;
				}
				_preferSoundComponentPosition = value;
				PropertySet(this);
			}
		}

		public audioEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
