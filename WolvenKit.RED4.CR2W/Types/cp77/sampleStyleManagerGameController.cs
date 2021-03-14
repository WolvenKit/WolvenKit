using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleStyleManagerGameController : gameuiWidgetGameController
	{
		private redResourceReferenceScriptToken _stylePath1;
		private redResourceReferenceScriptToken _stylePath2;
		private inkWidgetReference _content;

		[Ordinal(2)] 
		[RED("stylePath1")] 
		public redResourceReferenceScriptToken StylePath1
		{
			get
			{
				if (_stylePath1 == null)
				{
					_stylePath1 = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "stylePath1", cr2w, this);
				}
				return _stylePath1;
			}
			set
			{
				if (_stylePath1 == value)
				{
					return;
				}
				_stylePath1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stylePath2")] 
		public redResourceReferenceScriptToken StylePath2
		{
			get
			{
				if (_stylePath2 == null)
				{
					_stylePath2 = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "stylePath2", cr2w, this);
				}
				return _stylePath2;
			}
			set
			{
				if (_stylePath2 == value)
				{
					return;
				}
				_stylePath2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get
			{
				if (_content == null)
				{
					_content = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		public sampleStyleManagerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
