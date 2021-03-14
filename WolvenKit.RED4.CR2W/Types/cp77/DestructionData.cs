using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructionData : CVariable
	{
		private CEnum<EDeviceDurabilityType> _durabilityType;
		private CBool _canBeFixed;

		[Ordinal(0)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get
			{
				if (_durabilityType == null)
				{
					_durabilityType = (CEnum<EDeviceDurabilityType>) CR2WTypeManager.Create("EDeviceDurabilityType", "durabilityType", cr2w, this);
				}
				return _durabilityType;
			}
			set
			{
				if (_durabilityType == value)
				{
					return;
				}
				_durabilityType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("canBeFixed")] 
		public CBool CanBeFixed
		{
			get
			{
				if (_canBeFixed == null)
				{
					_canBeFixed = (CBool) CR2WTypeManager.Create("Bool", "canBeFixed", cr2w, this);
				}
				return _canBeFixed;
			}
			set
			{
				if (_canBeFixed == value)
				{
					return;
				}
				_canBeFixed = value;
				PropertySet(this);
			}
		}

		public DestructionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
