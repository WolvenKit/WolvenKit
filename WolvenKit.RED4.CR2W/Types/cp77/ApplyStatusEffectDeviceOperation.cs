using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectDeviceOperation : DeviceOperationBase
	{
		private CArray<SStatusEffectOperationData> _statusEffects;

		[Ordinal(5)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get
			{
				if (_statusEffects == null)
				{
					_statusEffects = (CArray<SStatusEffectOperationData>) CR2WTypeManager.Create("array:SStatusEffectOperationData", "statusEffects", cr2w, this);
				}
				return _statusEffects;
			}
			set
			{
				if (_statusEffects == value)
				{
					return;
				}
				_statusEffects = value;
				PropertySet(this);
			}
		}

		public ApplyStatusEffectDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
