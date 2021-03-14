using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsMultipleSetEnableEvent : redEvent
	{
		private CStatic<CBool> _enable;
		private CStatic<CName> _layer;
		private CStatic<CName> _linkedLayers;

		[Ordinal(0)] 
		[RED("enable", 4)] 
		public CStatic<CBool> Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CStatic<CBool>) CR2WTypeManager.Create("static:4,Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("layer", 4)] 
		public CStatic<CName> Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CStatic<CName>) CR2WTypeManager.Create("static:4,CName", "layer", cr2w, this);
				}
				return _layer;
			}
			set
			{
				if (_layer == value)
				{
					return;
				}
				_layer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("linkedLayers", 4)] 
		public CStatic<CName> LinkedLayers
		{
			get
			{
				if (_linkedLayers == null)
				{
					_linkedLayers = (CStatic<CName>) CR2WTypeManager.Create("static:4,CName", "linkedLayers", cr2w, this);
				}
				return _linkedLayers;
			}
			set
			{
				if (_linkedLayers == value)
				{
					return;
				}
				_linkedLayers = value;
				PropertySet(this);
			}
		}

		public gameinteractionsMultipleSetEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
