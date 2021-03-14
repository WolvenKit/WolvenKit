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
			get
			{
				if (_linkedLayersName == null)
				{
					_linkedLayersName = (CName) CR2WTypeManager.Create("CName", "linkedLayersName", cr2w, this);
				}
				return _linkedLayersName;
			}
			set
			{
				if (_linkedLayersName == value)
				{
					return;
				}
				_linkedLayersName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get
			{
				if (_layerName == null)
				{
					_layerName = (CName) CR2WTypeManager.Create("CName", "layerName", cr2w, this);
				}
				return _layerName;
			}
			set
			{
				if (_layerName == value)
				{
					return;
				}
				_layerName = value;
				PropertySet(this);
			}
		}

		public gameinteractionsLayerActivatedPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
