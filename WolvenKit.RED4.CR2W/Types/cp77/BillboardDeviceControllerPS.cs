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
			get
			{
				if (_glitchSFX == null)
				{
					_glitchSFX = (CName) CR2WTypeManager.Create("CName", "glitchSFX", cr2w, this);
				}
				return _glitchSFX;
			}
			set
			{
				if (_glitchSFX == value)
				{
					return;
				}
				_glitchSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("useLights")] 
		public CBool UseLights
		{
			get
			{
				if (_useLights == null)
				{
					_useLights = (CBool) CR2WTypeManager.Create("Bool", "useLights", cr2w, this);
				}
				return _useLights;
			}
			set
			{
				if (_useLights == value)
				{
					return;
				}
				_useLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("lightsSettings")] 
		public CArray<EditableGameLightSettings> LightsSettings
		{
			get
			{
				if (_lightsSettings == null)
				{
					_lightsSettings = (CArray<EditableGameLightSettings>) CR2WTypeManager.Create("array:EditableGameLightSettings", "lightsSettings", cr2w, this);
				}
				return _lightsSettings;
			}
			set
			{
				if (_lightsSettings == value)
				{
					return;
				}
				_lightsSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("useDeviceAppearence")] 
		public CBool UseDeviceAppearence
		{
			get
			{
				if (_useDeviceAppearence == null)
				{
					_useDeviceAppearence = (CBool) CR2WTypeManager.Create("Bool", "useDeviceAppearence", cr2w, this);
				}
				return _useDeviceAppearence;
			}
			set
			{
				if (_useDeviceAppearence == value)
				{
					return;
				}
				_useDeviceAppearence = value;
				PropertySet(this);
			}
		}

		public BillboardDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
