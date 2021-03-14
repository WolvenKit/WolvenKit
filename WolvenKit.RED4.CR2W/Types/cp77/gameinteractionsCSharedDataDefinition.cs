using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCSharedDataDefinition : CVariable
	{
		private CArray<CString> _defaultChoices;
		private CHandle<gameuiIChoiceVisualizer> _visualizer;

		[Ordinal(0)] 
		[RED("defaultChoices")] 
		public CArray<CString> DefaultChoices
		{
			get
			{
				if (_defaultChoices == null)
				{
					_defaultChoices = (CArray<CString>) CR2WTypeManager.Create("array:String", "defaultChoices", cr2w, this);
				}
				return _defaultChoices;
			}
			set
			{
				if (_defaultChoices == value)
				{
					return;
				}
				_defaultChoices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visualizer")] 
		public CHandle<gameuiIChoiceVisualizer> Visualizer
		{
			get
			{
				if (_visualizer == null)
				{
					_visualizer = (CHandle<gameuiIChoiceVisualizer>) CR2WTypeManager.Create("handle:gameuiIChoiceVisualizer", "visualizer", cr2w, this);
				}
				return _visualizer;
			}
			set
			{
				if (_visualizer == value)
				{
					return;
				}
				_visualizer = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCSharedDataDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
