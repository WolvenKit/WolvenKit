using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnvironmentColorGroupsSettings : IAreaSettings
	{
		private curveData<HDRColor> _skyTint;
		private CArrayFixedSize<curveData<HDRColor>> _colorGroup;

		[Ordinal(2)] 
		[RED("skyTint")] 
		public curveData<HDRColor> SkyTint
		{
			get
			{
				if (_skyTint == null)
				{
					_skyTint = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "skyTint", cr2w, this);
				}
				return _skyTint;
			}
			set
			{
				if (_skyTint == value)
				{
					return;
				}
				_skyTint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("colorGroup", 16)] 
		public CArrayFixedSize<curveData<HDRColor>> ColorGroup
		{
			get
			{
				if (_colorGroup == null)
				{
					_colorGroup = (CArrayFixedSize<curveData<HDRColor>>) CR2WTypeManager.Create("[16]curveData:HDRColor", "colorGroup", cr2w, this);
				}
				return _colorGroup;
			}
			set
			{
				if (_colorGroup == value)
				{
					return;
				}
				_colorGroup = value;
				PropertySet(this);
			}
		}

		public EnvironmentColorGroupsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
