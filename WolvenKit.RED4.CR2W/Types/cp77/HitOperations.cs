using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitOperations : DeviceOperations
	{
		private CArray<SHitOperationData> _hitOperations;

		[Ordinal(2)] 
		[RED("hitOperations")] 
		public CArray<SHitOperationData> HitOperations_
		{
			get
			{
				if (_hitOperations == null)
				{
					_hitOperations = (CArray<SHitOperationData>) CR2WTypeManager.Create("array:SHitOperationData", "hitOperations", cr2w, this);
				}
				return _hitOperations;
			}
			set
			{
				if (_hitOperations == value)
				{
					return;
				}
				_hitOperations = value;
				PropertySet(this);
			}
		}

		public HitOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
