using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPerformanceAreaNode : worldTriggerAreaNode
	{
		private CArray<worldQualitySetting> _qualitySettingsArray;
		private CName _disableCrowdUniqueName;
		private CFloat _globalStreamingDistanceScale;

		[Ordinal(7)] 
		[RED("qualitySettingsArray")] 
		public CArray<worldQualitySetting> QualitySettingsArray
		{
			get
			{
				if (_qualitySettingsArray == null)
				{
					_qualitySettingsArray = (CArray<worldQualitySetting>) CR2WTypeManager.Create("array:worldQualitySetting", "qualitySettingsArray", cr2w, this);
				}
				return _qualitySettingsArray;
			}
			set
			{
				if (_qualitySettingsArray == value)
				{
					return;
				}
				_qualitySettingsArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("disableCrowdUniqueName")] 
		public CName DisableCrowdUniqueName
		{
			get
			{
				if (_disableCrowdUniqueName == null)
				{
					_disableCrowdUniqueName = (CName) CR2WTypeManager.Create("CName", "disableCrowdUniqueName", cr2w, this);
				}
				return _disableCrowdUniqueName;
			}
			set
			{
				if (_disableCrowdUniqueName == value)
				{
					return;
				}
				_disableCrowdUniqueName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("globalStreamingDistanceScale")] 
		public CFloat GlobalStreamingDistanceScale
		{
			get
			{
				if (_globalStreamingDistanceScale == null)
				{
					_globalStreamingDistanceScale = (CFloat) CR2WTypeManager.Create("Float", "globalStreamingDistanceScale", cr2w, this);
				}
				return _globalStreamingDistanceScale;
			}
			set
			{
				if (_globalStreamingDistanceScale == value)
				{
					return;
				}
				_globalStreamingDistanceScale = value;
				PropertySet(this);
			}
		}

		public worldPerformanceAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
