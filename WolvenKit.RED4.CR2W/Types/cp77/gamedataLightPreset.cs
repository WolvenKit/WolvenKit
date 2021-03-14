using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataLightPreset : CVariable
	{
		private CName _lightSourcesName;
		private TweakDBID _preset;

		[Ordinal(0)] 
		[RED("lightSourcesName")] 
		public CName LightSourcesName
		{
			get
			{
				if (_lightSourcesName == null)
				{
					_lightSourcesName = (CName) CR2WTypeManager.Create("CName", "lightSourcesName", cr2w, this);
				}
				return _lightSourcesName;
			}
			set
			{
				if (_lightSourcesName == value)
				{
					return;
				}
				_lightSourcesName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("preset")] 
		public TweakDBID Preset
		{
			get
			{
				if (_preset == null)
				{
					_preset = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "preset", cr2w, this);
				}
				return _preset;
			}
			set
			{
				if (_preset == value)
				{
					return;
				}
				_preset = value;
				PropertySet(this);
			}
		}

		public gamedataLightPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
