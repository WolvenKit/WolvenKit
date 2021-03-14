using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebuggerProperties : CVariable
	{
		private CBool _exclusiveMode;
		private CName _factActivated;
		private CName _debugName;
		private CArray<CUInt32> _layerIDs;

		[Ordinal(0)] 
		[RED("exclusiveMode")] 
		public CBool ExclusiveMode
		{
			get
			{
				if (_exclusiveMode == null)
				{
					_exclusiveMode = (CBool) CR2WTypeManager.Create("Bool", "exclusiveMode", cr2w, this);
				}
				return _exclusiveMode;
			}
			set
			{
				if (_exclusiveMode == value)
				{
					return;
				}
				_exclusiveMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("factActivated")] 
		public CName FactActivated
		{
			get
			{
				if (_factActivated == null)
				{
					_factActivated = (CName) CR2WTypeManager.Create("CName", "factActivated", cr2w, this);
				}
				return _factActivated;
			}
			set
			{
				if (_factActivated == value)
				{
					return;
				}
				_factActivated = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get
			{
				if (_debugName == null)
				{
					_debugName = (CName) CR2WTypeManager.Create("CName", "debugName", cr2w, this);
				}
				return _debugName;
			}
			set
			{
				if (_debugName == value)
				{
					return;
				}
				_debugName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get
			{
				if (_layerIDs == null)
				{
					_layerIDs = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "layerIDs", cr2w, this);
				}
				return _layerIDs;
			}
			set
			{
				if (_layerIDs == value)
				{
					return;
				}
				_layerIDs = value;
				PropertySet(this);
			}
		}

		public DebuggerProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
