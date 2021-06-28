using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SActionTypeForward : CVariable
	{
		private CBool _qHack;
		private CBool _techie;
		private CBool _master;

		[Ordinal(0)] 
		[RED("qHack")] 
		public CBool QHack
		{
			get => GetProperty(ref _qHack);
			set => SetProperty(ref _qHack, value);
		}

		[Ordinal(1)] 
		[RED("techie")] 
		public CBool Techie
		{
			get => GetProperty(ref _techie);
			set => SetProperty(ref _techie, value);
		}

		[Ordinal(2)] 
		[RED("master")] 
		public CBool Master
		{
			get => GetProperty(ref _master);
			set => SetProperty(ref _master, value);
		}

		public SActionTypeForward(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
