using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceMetaData : CVariable
	{
		private CString _tweakDBName;
		private TweakDBID _tweakDBID;
		private gameinteractionsChoiceTypeWrapper _type;

		[Ordinal(0)] 
		[RED("tweakDBName")] 
		public CString TweakDBName
		{
			get => GetProperty(ref _tweakDBName);
			set => SetProperty(ref _tweakDBName, value);
		}

		[Ordinal(1)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get => GetProperty(ref _tweakDBID);
			set => SetProperty(ref _tweakDBID, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public gameinteractionsChoiceMetaData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
