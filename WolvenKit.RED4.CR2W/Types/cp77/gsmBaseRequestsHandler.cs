using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gsmBaseRequestsHandler : inkISystemRequestsHandler
	{
		private gsmSavingRequesResult _savingComplete;

		[Ordinal(6)] 
		[RED("SavingComplete")] 
		public gsmSavingRequesResult SavingComplete
		{
			get => GetProperty(ref _savingComplete);
			set => SetProperty(ref _savingComplete, value);
		}

		public gsmBaseRequestsHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
