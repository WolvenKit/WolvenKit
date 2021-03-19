using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuppressSecuritySystemReaction : redEvent
	{
		private CBool _enableProtection;
		private entEntityID _protectedEntityID;
		private CBool _entered;
		private CBool _hasEntityWithdrawn;

		[Ordinal(0)] 
		[RED("enableProtection")] 
		public CBool EnableProtection
		{
			get => GetProperty(ref _enableProtection);
			set => SetProperty(ref _enableProtection, value);
		}

		[Ordinal(1)] 
		[RED("protectedEntityID")] 
		public entEntityID ProtectedEntityID
		{
			get => GetProperty(ref _protectedEntityID);
			set => SetProperty(ref _protectedEntityID, value);
		}

		[Ordinal(2)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetProperty(ref _entered);
			set => SetProperty(ref _entered, value);
		}

		[Ordinal(3)] 
		[RED("hasEntityWithdrawn")] 
		public CBool HasEntityWithdrawn
		{
			get => GetProperty(ref _hasEntityWithdrawn);
			set => SetProperty(ref _hasEntityWithdrawn, value);
		}

		public SuppressSecuritySystemReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
