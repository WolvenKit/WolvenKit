using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsSetEnableEvent : redEvent
	{
		private CBool _enable;
		private CName _linkedLayers;
		private CName _layer;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
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
		[RED("linkedLayers")] 
		public CName LinkedLayers
		{
			get
			{
				if (_linkedLayers == null)
				{
					_linkedLayers = (CName) CR2WTypeManager.Create("CName", "linkedLayers", cr2w, this);
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

		[Ordinal(2)] 
		[RED("layer")] 
		public CName Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CName) CR2WTypeManager.Create("CName", "layer", cr2w, this);
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

		public gameinteractionsSetEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
