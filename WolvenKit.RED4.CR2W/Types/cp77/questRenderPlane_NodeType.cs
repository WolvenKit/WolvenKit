using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRenderPlane_NodeType : questIRenderFxManagerNodeType
	{
		private gameEntityReference _puppetRef;
		private CEnum<ERenderingPlane> _renderPlane;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("renderPlane")] 
		public CEnum<ERenderingPlane> RenderPlane
		{
			get
			{
				if (_renderPlane == null)
				{
					_renderPlane = (CEnum<ERenderingPlane>) CR2WTypeManager.Create("ERenderingPlane", "renderPlane", cr2w, this);
				}
				return _renderPlane;
			}
			set
			{
				if (_renderPlane == value)
				{
					return;
				}
				_renderPlane = value;
				PropertySet(this);
			}
		}

		public questRenderPlane_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
