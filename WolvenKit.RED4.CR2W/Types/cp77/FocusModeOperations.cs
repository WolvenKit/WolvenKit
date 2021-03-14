using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperations : DeviceOperations
	{
		private CArray<SFocusModeOperationData> _focusModeOperations;

		[Ordinal(2)] 
		[RED("focusModeOperations")] 
		public CArray<SFocusModeOperationData> FocusModeOperations_
		{
			get
			{
				if (_focusModeOperations == null)
				{
					_focusModeOperations = (CArray<SFocusModeOperationData>) CR2WTypeManager.Create("array:SFocusModeOperationData", "focusModeOperations", cr2w, this);
				}
				return _focusModeOperations;
			}
			set
			{
				if (_focusModeOperations == value)
				{
					return;
				}
				_focusModeOperations = value;
				PropertySet(this);
			}
		}

		public FocusModeOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
