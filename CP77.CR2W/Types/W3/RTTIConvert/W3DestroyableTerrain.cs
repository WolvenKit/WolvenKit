using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DestroyableTerrain : CInteractiveEntity
	{
		[Ordinal(1)] [RED("m_destroyableElements", 2,0)] 		public CArray<CArray<CHandle<CScriptedDestroyableComponent>>> M_destroyableElements { get; set;}

		[Ordinal(2)] [RED("m_piecesIdToSplit", 2,0)] 		public CArray<CInt32> M_piecesIdToSplit { get; set;}

		[Ordinal(3)] [RED("m_player")] 		public CHandle<CPlayer> M_player { get; set;}

		[Ordinal(4)] [RED("m_activated")] 		public CBool M_activated { get; set;}

		[Ordinal(5)] [RED("m_componentName")] 		public CString M_componentName { get; set;}

		[Ordinal(6)] [RED("m_randNumber")] 		public CInt32 M_randNumber { get; set;}

		[Ordinal(7)] [RED("tickTime")] 		public CFloat TickTime { get; set;}

		[Ordinal(8)] [RED("tickInterval")] 		public CFloat TickInterval { get; set;}

		[Ordinal(9)] [RED("currRandNumbId")] 		public CInt32 CurrRandNumbId { get; set;}

		[Ordinal(10)] [RED("currRandNumbTime")] 		public CFloat CurrRandNumbTime { get; set;}

		[Ordinal(11)] [RED("m_numOfPiecesToDestroy")] 		public CInt32 M_numOfPiecesToDestroy { get; set;}

		[Ordinal(12)] [RED("m_timeBetweenRandomDestroyMin")] 		public CInt32 M_timeBetweenRandomDestroyMin { get; set;}

		[Ordinal(13)] [RED("m_timeBetweenRandomDestroyMax")] 		public CInt32 M_timeBetweenRandomDestroyMax { get; set;}

		public W3DestroyableTerrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DestroyableTerrain(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}