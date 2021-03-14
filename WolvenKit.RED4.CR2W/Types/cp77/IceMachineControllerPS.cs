using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IceMachineControllerPS : VendingMachineControllerPS
	{
		private TweakDBID _vendorTweakID;
		private IceMachineSFX _iceMachineSFX;

		[Ordinal(111)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get
			{
				if (_vendorTweakID == null)
				{
					_vendorTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "vendorTweakID", cr2w, this);
				}
				return _vendorTweakID;
			}
			set
			{
				if (_vendorTweakID == value)
				{
					return;
				}
				_vendorTweakID = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("iceMachineSFX")] 
		public IceMachineSFX IceMachineSFX
		{
			get
			{
				if (_iceMachineSFX == null)
				{
					_iceMachineSFX = (IceMachineSFX) CR2WTypeManager.Create("IceMachineSFX", "iceMachineSFX", cr2w, this);
				}
				return _iceMachineSFX;
			}
			set
			{
				if (_iceMachineSFX == value)
				{
					return;
				}
				_iceMachineSFX = value;
				PropertySet(this);
			}
		}

		public IceMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
