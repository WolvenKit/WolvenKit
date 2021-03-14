using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineSetup : CVariable
	{
		private CFloat _timeToCompletePurchase;

		[Ordinal(0)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get
			{
				if (_timeToCompletePurchase == null)
				{
					_timeToCompletePurchase = (CFloat) CR2WTypeManager.Create("Float", "timeToCompletePurchase", cr2w, this);
				}
				return _timeToCompletePurchase;
			}
			set
			{
				if (_timeToCompletePurchase == value)
				{
					return;
				}
				_timeToCompletePurchase = value;
				PropertySet(this);
			}
		}

		public VendingMachineSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
