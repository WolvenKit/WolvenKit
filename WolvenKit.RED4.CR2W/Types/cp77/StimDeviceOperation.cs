using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimDeviceOperation : DeviceOperationBase
	{
		private CArray<SStimOperationData> _stims;

		[Ordinal(5)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get
			{
				if (_stims == null)
				{
					_stims = (CArray<SStimOperationData>) CR2WTypeManager.Create("array:SStimOperationData", "stims", cr2w, this);
				}
				return _stims;
			}
			set
			{
				if (_stims == value)
				{
					return;
				}
				_stims = value;
				PropertySet(this);
			}
		}

		public StimDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
