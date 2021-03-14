using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotDefinition : CVariable
	{
		private CBool _suppressor;
		private CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> _layersDefinition;

		[Ordinal(0)] 
		[RED("suppressor")] 
		public CBool Suppressor
		{
			get
			{
				if (_suppressor == null)
				{
					_suppressor = (CBool) CR2WTypeManager.Create("Bool", "suppressor", cr2w, this);
				}
				return _suppressor;
			}
			set
			{
				if (_suppressor == value)
				{
					return;
				}
				_suppressor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("layersDefinition")] 
		public CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> LayersDefinition
		{
			get
			{
				if (_layersDefinition == null)
				{
					_layersDefinition = (CArray<CHandle<gameinteractionsCLinkedLayersDefinition>>) CR2WTypeManager.Create("array:handle:gameinteractionsCLinkedLayersDefinition", "layersDefinition", cr2w, this);
				}
				return _layersDefinition;
			}
			set
			{
				if (_layersDefinition == value)
				{
					return;
				}
				_layersDefinition = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCHotSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
