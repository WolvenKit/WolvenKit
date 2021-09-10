using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutlineRequestManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("requestsList")] 
		public CArray<CHandle<OutlineRequest>> RequestsList
		{
			get => GetPropertyValue<CArray<CHandle<OutlineRequest>>>();
			set => SetPropertyValue<CArray<CHandle<OutlineRequest>>>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("dbgRequests")] 
		public CArray<CHandle<OutlineRequest>> DbgRequests
		{
			get => GetPropertyValue<CArray<CHandle<OutlineRequest>>>();
			set => SetPropertyValue<CArray<CHandle<OutlineRequest>>>(value);
		}

		public OutlineRequestManager()
		{
			RequestsList = new();
			DbgRequests = new();
		}
	}
}
