using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_ContainersStruct : CVariable
	{
		private inkWidgetReference _widgetBody;
		private inkWidgetReference _widgetCool;
		private inkWidgetReference _widgetInt;
		private inkWidgetReference _widgetRef;
		private inkWidgetReference _widgetTech;
		private CHandle<CyberwareAttributes_Logic> _logicBody;
		private CHandle<CyberwareAttributes_Logic> _logicCool;
		private CHandle<CyberwareAttributes_Logic> _logicInt;
		private CHandle<CyberwareAttributes_Logic> _logicRef;
		private CHandle<CyberwareAttributes_Logic> _logicTech;

		[Ordinal(0)] 
		[RED("widgetBody")] 
		public inkWidgetReference WidgetBody
		{
			get
			{
				if (_widgetBody == null)
				{
					_widgetBody = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetBody", cr2w, this);
				}
				return _widgetBody;
			}
			set
			{
				if (_widgetBody == value)
				{
					return;
				}
				_widgetBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("widgetCool")] 
		public inkWidgetReference WidgetCool
		{
			get
			{
				if (_widgetCool == null)
				{
					_widgetCool = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetCool", cr2w, this);
				}
				return _widgetCool;
			}
			set
			{
				if (_widgetCool == value)
				{
					return;
				}
				_widgetCool = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("widgetInt")] 
		public inkWidgetReference WidgetInt
		{
			get
			{
				if (_widgetInt == null)
				{
					_widgetInt = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetInt", cr2w, this);
				}
				return _widgetInt;
			}
			set
			{
				if (_widgetInt == value)
				{
					return;
				}
				_widgetInt = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("widgetRef")] 
		public inkWidgetReference WidgetRef
		{
			get
			{
				if (_widgetRef == null)
				{
					_widgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetRef", cr2w, this);
				}
				return _widgetRef;
			}
			set
			{
				if (_widgetRef == value)
				{
					return;
				}
				_widgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("widgetTech")] 
		public inkWidgetReference WidgetTech
		{
			get
			{
				if (_widgetTech == null)
				{
					_widgetTech = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetTech", cr2w, this);
				}
				return _widgetTech;
			}
			set
			{
				if (_widgetTech == value)
				{
					return;
				}
				_widgetTech = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("logicBody")] 
		public CHandle<CyberwareAttributes_Logic> LogicBody
		{
			get
			{
				if (_logicBody == null)
				{
					_logicBody = (CHandle<CyberwareAttributes_Logic>) CR2WTypeManager.Create("handle:CyberwareAttributes_Logic", "logicBody", cr2w, this);
				}
				return _logicBody;
			}
			set
			{
				if (_logicBody == value)
				{
					return;
				}
				_logicBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("logicCool")] 
		public CHandle<CyberwareAttributes_Logic> LogicCool
		{
			get
			{
				if (_logicCool == null)
				{
					_logicCool = (CHandle<CyberwareAttributes_Logic>) CR2WTypeManager.Create("handle:CyberwareAttributes_Logic", "logicCool", cr2w, this);
				}
				return _logicCool;
			}
			set
			{
				if (_logicCool == value)
				{
					return;
				}
				_logicCool = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("logicInt")] 
		public CHandle<CyberwareAttributes_Logic> LogicInt
		{
			get
			{
				if (_logicInt == null)
				{
					_logicInt = (CHandle<CyberwareAttributes_Logic>) CR2WTypeManager.Create("handle:CyberwareAttributes_Logic", "logicInt", cr2w, this);
				}
				return _logicInt;
			}
			set
			{
				if (_logicInt == value)
				{
					return;
				}
				_logicInt = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("logicRef")] 
		public CHandle<CyberwareAttributes_Logic> LogicRef
		{
			get
			{
				if (_logicRef == null)
				{
					_logicRef = (CHandle<CyberwareAttributes_Logic>) CR2WTypeManager.Create("handle:CyberwareAttributes_Logic", "logicRef", cr2w, this);
				}
				return _logicRef;
			}
			set
			{
				if (_logicRef == value)
				{
					return;
				}
				_logicRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("logicTech")] 
		public CHandle<CyberwareAttributes_Logic> LogicTech
		{
			get
			{
				if (_logicTech == null)
				{
					_logicTech = (CHandle<CyberwareAttributes_Logic>) CR2WTypeManager.Create("handle:CyberwareAttributes_Logic", "logicTech", cr2w, this);
				}
				return _logicTech;
			}
			set
			{
				if (_logicTech == value)
				{
					return;
				}
				_logicTech = value;
				PropertySet(this);
			}
		}

		public CyberwareAttributes_ContainersStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
