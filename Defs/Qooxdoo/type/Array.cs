// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.type
{
    /// <summary>
	/// <para>An extended array class which adds a lot of often used
	/// convenience methods to the regular array like remove or
	/// contains.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.type.Array", OmitOptionalParameters = true, Export = false)]
    public partial class Array : qx.type.BaseArray
    {
		#region Methods

		public Array() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a new Array with the given length or the listed items.</para>
		/// <code>
		/// var arr1 = new qx.type.Array(length);
		/// var arr2 = new qx.type.Array(elem0, elem1, ..., elemN);
		/// </code>
		/// <list type="bullet">
		/// <item>length: The initial length of the array.</item>
		/// <item>item1, item2. .. itemN:  the items that will make up the newly created array</item>
		/// </list
		/// </summary>
		/// <param name="length_or_items">The initial size of the collection OR an argument list of elements.</param>
		public Array(object length_or_items = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Append the elements of the given array</para>
		/// </summary>
		/// <param name="arr">the elements of this array will be appended to other one</param>
		/// <returns>The modified array.</returns>
		[JsMethod(Name = "append")]
		public JsArray Append(JsArray arr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a clone of the array. Primitive values are copied.
		/// Others are referenced.</para>
		/// </summary>
		/// <returns>Cloned array instance</returns>
		[JsMethod(Name = "clone")]
		public JsArray Clone() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the array contains the given element</para>
		/// </summary>
		/// <param name="obj">object to look for</param>
		/// <returns>whether the array contains the element</returns>
		[JsMethod(Name = "contains")]
		public bool Contains(object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Insert an element after a given second element</para>
		/// </summary>
		/// <param name="obj">object to be inserted</param>
		/// <param name="obj2">insert obj1 after this object</param>
		/// <returns>the array</returns>
		[JsMethod(Name = "insertAfter")]
		public JsArray InsertAfter(object obj, object obj2) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Insert an element at a given position</para>
		/// </summary>
		/// <param name="obj">the element to insert</param>
		/// <param name="i">position where to insert the element into the arr</param>
		/// <returns>the array</returns>
		[JsMethod(Name = "insertAt")]
		public JsArray InsertAt(object obj, double i) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Insert an element before a given second element</para>
		/// </summary>
		/// <param name="obj">object to be inserted</param>
		/// <param name="obj2">insert obj1 before this object</param>
		/// <returns>the array</returns>
		[JsMethod(Name = "insertBefore")]
		public JsArray InsertBefore(object obj, object obj2) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prepend the elements of the given array.</para>
		/// </summary>
		/// <param name="arr">The elements of this array will be prepended to other one</param>
		/// <returns>The modified array.</returns>
		[JsMethod(Name = "prepend")]
		public JsArray Prepend(JsArray arr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove an element</para>
		/// </summary>
		/// <param name="obj">element to be removed from the array</param>
		/// <returns>the removed element</returns>
		[JsMethod(Name = "remove")]
		public object Remove(object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all elements</para>
		/// </summary>
		/// <returns>empty array</returns>
		[JsMethod(Name = "removeAll")]
		public JsArray RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove an element at the given index</para>
		/// </summary>
		/// <param name="i">index of the element to be removed</param>
		/// <returns>The removed element.</returns>
		[JsMethod(Name = "removeAt")]
		public object RemoveAt(double i) { throw new NotImplementedException(); }

		#endregion Methods
    }
}