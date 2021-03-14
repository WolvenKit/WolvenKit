using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class District : IScriptable
	{
		private TweakDBID _districtID;
		private TweakDBID _presetID;

		[Ordinal(0)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get
			{
				if (_districtID == null)
				{
					_districtID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "districtID", cr2w, this);
				}
				return _districtID;
			}
			set
			{
				if (_districtID == value)
				{
					return;
				}
				_districtID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get
			{
				if (_presetID == null)
				{
					_presetID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "presetID", cr2w, this);
				}
				return _presetID;
			}
			set
			{
				if (_presetID == value)
				{
					return;
				}
				_presetID = value;
				PropertySet(this);
			}
		}

		public District(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
