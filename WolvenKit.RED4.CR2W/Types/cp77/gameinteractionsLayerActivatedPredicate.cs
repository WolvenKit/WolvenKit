using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLayerActivatedPredicate : gameinteractionsIPredicateType
	{
		private CName _linkedLayersName;
		private CName _layerName;

		[Ordinal(0)] 
		[RED("linkedLayersName")] 
		public CName LinkedLayersName
		{
			get => GetProperty(ref _linkedLayersName);
			set => SetProperty(ref _linkedLayersName, value);
		}

		[Ordinal(1)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetProperty(ref _layerName);
			set => SetProperty(ref _layerName, value);
		}

		public gameinteractionsLayerActivatedPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
