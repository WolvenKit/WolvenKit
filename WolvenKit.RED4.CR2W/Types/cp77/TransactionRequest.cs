using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransactionRequest : MarketSystemRequest
	{
		private CArray<TransactionRequestData> _items;

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<TransactionRequestData> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<TransactionRequestData>) CR2WTypeManager.Create("array:TransactionRequestData", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		public TransactionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
