using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMiscAICommandNode : questConfigurableAICommandNode
	{
		private gameEntityReference _entityReference;
		private CName _function;
		private CHandle<questAICommandParams> _params;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityReference", cr2w, this);
				}
				return _entityReference;
			}
			set
			{
				if (_entityReference == value)
				{
					return;
				}
				_entityReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("function")] 
		public CName Function
		{
			get
			{
				if (_function == null)
				{
					_function = (CName) CR2WTypeManager.Create("CName", "function", cr2w, this);
				}
				return _function;
			}
			set
			{
				if (_function == value)
				{
					return;
				}
				_function = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("params")] 
		public CHandle<questAICommandParams> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CHandle<questAICommandParams>) CR2WTypeManager.Create("handle:questAICommandParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public questMiscAICommandNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
