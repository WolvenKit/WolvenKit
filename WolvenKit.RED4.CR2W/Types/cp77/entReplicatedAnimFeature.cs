using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedAnimFeature : entReplicatedItem
	{
		private CName _name;
		private CHandle<animAnimFeature> _value;
		private CBool _invokeCallback;

		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CHandle<animAnimFeature> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CHandle<animAnimFeature>) CR2WTypeManager.Create("handle:animAnimFeature", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("invokeCallback")] 
		public CBool InvokeCallback
		{
			get
			{
				if (_invokeCallback == null)
				{
					_invokeCallback = (CBool) CR2WTypeManager.Create("Bool", "invokeCallback", cr2w, this);
				}
				return _invokeCallback;
			}
			set
			{
				if (_invokeCallback == value)
				{
					return;
				}
				_invokeCallback = value;
				PropertySet(this);
			}
		}

		public entReplicatedAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
