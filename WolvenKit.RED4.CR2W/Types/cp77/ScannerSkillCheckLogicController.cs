using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckLogicController : inkWidgetLogicController
	{
		private CName _scannerSkillCheckItemName;
		private CArray<wCHandle<inkWidget>> _skillCheckObjects;
		private wCHandle<inkCompoundWidget> _root;

		[Ordinal(1)] 
		[RED("ScannerSkillCheckItemName")] 
		public CName ScannerSkillCheckItemName
		{
			get
			{
				if (_scannerSkillCheckItemName == null)
				{
					_scannerSkillCheckItemName = (CName) CR2WTypeManager.Create("CName", "ScannerSkillCheckItemName", cr2w, this);
				}
				return _scannerSkillCheckItemName;
			}
			set
			{
				if (_scannerSkillCheckItemName == value)
				{
					return;
				}
				_scannerSkillCheckItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SkillCheckObjects")] 
		public CArray<wCHandle<inkWidget>> SkillCheckObjects
		{
			get
			{
				if (_skillCheckObjects == null)
				{
					_skillCheckObjects = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "SkillCheckObjects", cr2w, this);
				}
				return _skillCheckObjects;
			}
			set
			{
				if (_skillCheckObjects == value)
				{
					return;
				}
				_skillCheckObjects = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "Root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		public ScannerSkillCheckLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
