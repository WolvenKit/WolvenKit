using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseResaveData : CVariable
	{
		private BaseDeviceData _baseDeviceData;
		private TweakDBID _tweakDBRecord;

		[Ordinal(0)] 
		[RED("baseDeviceData")] 
		public BaseDeviceData BaseDeviceData
		{
			get
			{
				if (_baseDeviceData == null)
				{
					_baseDeviceData = (BaseDeviceData) CR2WTypeManager.Create("BaseDeviceData", "baseDeviceData", cr2w, this);
				}
				return _baseDeviceData;
			}
			set
			{
				if (_baseDeviceData == value)
				{
					return;
				}
				_baseDeviceData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tweakDBRecord")] 
		public TweakDBID TweakDBRecord
		{
			get
			{
				if (_tweakDBRecord == null)
				{
					_tweakDBRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tweakDBRecord", cr2w, this);
				}
				return _tweakDBRecord;
			}
			set
			{
				if (_tweakDBRecord == value)
				{
					return;
				}
				_tweakDBRecord = value;
				PropertySet(this);
			}
		}

		public BaseResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
