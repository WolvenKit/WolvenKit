using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseActionOperations : DeviceOperations
	{
		private CArray<SBaseActionOperationData> _baseActionsOperations;

		[Ordinal(2)] 
		[RED("baseActionsOperations")] 
		public CArray<SBaseActionOperationData> BaseActionsOperations
		{
			get
			{
				if (_baseActionsOperations == null)
				{
					_baseActionsOperations = (CArray<SBaseActionOperationData>) CR2WTypeManager.Create("array:SBaseActionOperationData", "baseActionsOperations", cr2w, this);
				}
				return _baseActionsOperations;
			}
			set
			{
				if (_baseActionsOperations == value)
				{
					return;
				}
				_baseActionsOperations = value;
				PropertySet(this);
			}
		}

		public BaseActionOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
