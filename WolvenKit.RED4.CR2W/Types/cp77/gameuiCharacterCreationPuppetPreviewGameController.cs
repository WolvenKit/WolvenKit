using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCreationPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		private CName _maleSceneName;
		private CName _femaleSceneName;
		private NodeRef _maleCamera01Ref;
		private NodeRef _femaleCamera01Ref;
		private inkCompoundWidgetReference _root;
		private inkImageWidgetReference _image;
		private inkWidgetLibraryReference _animLib;
		private CName _animName;

		[Ordinal(7)] 
		[RED("maleSceneName")] 
		public CName MaleSceneName
		{
			get
			{
				if (_maleSceneName == null)
				{
					_maleSceneName = (CName) CR2WTypeManager.Create("CName", "maleSceneName", cr2w, this);
				}
				return _maleSceneName;
			}
			set
			{
				if (_maleSceneName == value)
				{
					return;
				}
				_maleSceneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("femaleSceneName")] 
		public CName FemaleSceneName
		{
			get
			{
				if (_femaleSceneName == null)
				{
					_femaleSceneName = (CName) CR2WTypeManager.Create("CName", "femaleSceneName", cr2w, this);
				}
				return _femaleSceneName;
			}
			set
			{
				if (_femaleSceneName == value)
				{
					return;
				}
				_femaleSceneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("maleCamera01Ref")] 
		public NodeRef MaleCamera01Ref
		{
			get
			{
				if (_maleCamera01Ref == null)
				{
					_maleCamera01Ref = (NodeRef) CR2WTypeManager.Create("NodeRef", "maleCamera01Ref", cr2w, this);
				}
				return _maleCamera01Ref;
			}
			set
			{
				if (_maleCamera01Ref == value)
				{
					return;
				}
				_maleCamera01Ref = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("femaleCamera01Ref")] 
		public NodeRef FemaleCamera01Ref
		{
			get
			{
				if (_femaleCamera01Ref == null)
				{
					_femaleCamera01Ref = (NodeRef) CR2WTypeManager.Create("NodeRef", "femaleCamera01Ref", cr2w, this);
				}
				return _femaleCamera01Ref;
			}
			set
			{
				if (_femaleCamera01Ref == value)
				{
					return;
				}
				_femaleCamera01Ref = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("root")] 
		public inkCompoundWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "root", cr2w, this);
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

		[Ordinal(12)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get
			{
				if (_image == null)
				{
					_image = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animLib")] 
		public inkWidgetLibraryReference AnimLib
		{
			get
			{
				if (_animLib == null)
				{
					_animLib = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "animLib", cr2w, this);
				}
				return _animLib;
			}
			set
			{
				if (_animLib == value)
				{
					return;
				}
				_animLib = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCreationPuppetPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
