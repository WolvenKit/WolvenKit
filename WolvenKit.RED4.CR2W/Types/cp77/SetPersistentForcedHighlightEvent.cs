using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPersistentForcedHighlightEvent : redEvent
	{
		private CName _sourceName;
		private CHandle<HighlightEditableData> _highlightData;
		private CEnum<EToggleOperationType> _operation;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get
			{
				if (_sourceName == null)
				{
					_sourceName = (CName) CR2WTypeManager.Create("CName", "sourceName", cr2w, this);
				}
				return _sourceName;
			}
			set
			{
				if (_sourceName == value)
				{
					return;
				}
				_sourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("highlightData")] 
		public CHandle<HighlightEditableData> HighlightData
		{
			get
			{
				if (_highlightData == null)
				{
					_highlightData = (CHandle<HighlightEditableData>) CR2WTypeManager.Create("handle:HighlightEditableData", "highlightData", cr2w, this);
				}
				return _highlightData;
			}
			set
			{
				if (_highlightData == value)
				{
					return;
				}
				_highlightData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("operation")] 
		public CEnum<EToggleOperationType> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CEnum<EToggleOperationType>) CR2WTypeManager.Create("EToggleOperationType", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		public SetPersistentForcedHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
