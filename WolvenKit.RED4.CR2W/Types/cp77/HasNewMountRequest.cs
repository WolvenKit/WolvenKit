using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HasNewMountRequest : AIVehicleConditionAbstract
	{
		private CHandle<AIArgumentMapping> _mountRequest;
		private CBool _checkOnlyInstant;

		[Ordinal(0)] 
		[RED("mountRequest")] 
		public CHandle<AIArgumentMapping> MountRequest
		{
			get
			{
				if (_mountRequest == null)
				{
					_mountRequest = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountRequest", cr2w, this);
				}
				return _mountRequest;
			}
			set
			{
				if (_mountRequest == value)
				{
					return;
				}
				_mountRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("checkOnlyInstant")] 
		public CBool CheckOnlyInstant
		{
			get
			{
				if (_checkOnlyInstant == null)
				{
					_checkOnlyInstant = (CBool) CR2WTypeManager.Create("Bool", "checkOnlyInstant", cr2w, this);
				}
				return _checkOnlyInstant;
			}
			set
			{
				if (_checkOnlyInstant == value)
				{
					return;
				}
				_checkOnlyInstant = value;
				PropertySet(this);
			}
		}

		public HasNewMountRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
