/* 
 * MELI Markeplace SDK
 *
 * This is a the codebase to generate a SDK for Open Platform Marketplace
 *
 * The version of the OpenAPI document: 0.0.24
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MeliLibTools.Client.OpenAPIDateConverter;

namespace MeliLibTools.Model
{
    /// <summary>
    /// Item
    /// </summary>
    [DataContract]
    public partial class Item :  IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="categoryId">categoryId (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="currencyId">currencyId (required).</param>
        /// <param name="availableQuantity">availableQuantity (required).</param>
        /// <param name="buyingMode">buyingMode (required).</param>
        /// <param name="listingTypeId">listingTypeId (required).</param>
        /// <param name="condition">condition (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="videoId">videoId (required).</param>
        /// <param name="warranty">warranty (required).</param>
        /// <param name="pictures">pictures (required).</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="variations">variations.</param>
        public Item(int title = default(int), int categoryId = default(int), int price = default(int), string currencyId = default(string), string availableQuantity = default(string), string buyingMode = default(string), string listingTypeId = default(string), string condition = default(string), string description = default(string), string videoId = default(string), string warranty = default(string), List<ItemPictures> pictures = default(List<ItemPictures>), List<Attributes> attributes = default(List<Attributes>), List<Variations> variations = default(List<Variations>))
        {
            this.Title = title;
            this.CategoryId = categoryId;
            this.Price = price;
            // to ensure "currencyId" is required (not null)
            this.CurrencyId = currencyId ?? throw new ArgumentNullException("currencyId is a required property for Item and cannot be null");;
            // to ensure "availableQuantity" is required (not null)
            this.AvailableQuantity = availableQuantity ?? throw new ArgumentNullException("availableQuantity is a required property for Item and cannot be null");;
            // to ensure "buyingMode" is required (not null)
            this.BuyingMode = buyingMode ?? throw new ArgumentNullException("buyingMode is a required property for Item and cannot be null");;
            // to ensure "listingTypeId" is required (not null)
            this.ListingTypeId = listingTypeId ?? throw new ArgumentNullException("listingTypeId is a required property for Item and cannot be null");;
            // to ensure "condition" is required (not null)
            this.Condition = condition ?? throw new ArgumentNullException("condition is a required property for Item and cannot be null");;
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for Item and cannot be null");;
            // to ensure "videoId" is required (not null)
            this.VideoId = videoId ?? throw new ArgumentNullException("videoId is a required property for Item and cannot be null");;
            // to ensure "warranty" is required (not null)
            this.Warranty = warranty ?? throw new ArgumentNullException("warranty is a required property for Item and cannot be null");;
            // to ensure "pictures" is required (not null)
            this.Pictures = pictures ?? throw new ArgumentNullException("pictures is a required property for Item and cannot be null");;
            this.Attributes = attributes;
            this.Variations = variations;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public int Title { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int Price { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets AvailableQuantity
        /// </summary>
        [DataMember(Name="available_quantity", EmitDefaultValue=false)]
        public string AvailableQuantity { get; set; }

        /// <summary>
        /// Gets or Sets BuyingMode
        /// </summary>
        [DataMember(Name="buying_mode", EmitDefaultValue=false)]
        public string BuyingMode { get; set; }

        /// <summary>
        /// Gets or Sets ListingTypeId
        /// </summary>
        [DataMember(Name="listing_type_id", EmitDefaultValue=false)]
        public string ListingTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets VideoId
        /// </summary>
        [DataMember(Name="video_id", EmitDefaultValue=false)]
        public string VideoId { get; set; }

        /// <summary>
        /// Gets or Sets Warranty
        /// </summary>
        [DataMember(Name="warranty", EmitDefaultValue=false)]
        public string Warranty { get; set; }

        /// <summary>
        /// Gets or Sets Pictures
        /// </summary>
        [DataMember(Name="pictures", EmitDefaultValue=false)]
        public List<ItemPictures> Pictures { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<Attributes> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Variations
        /// </summary>
        [DataMember(Name="variations", EmitDefaultValue=false)]
        public List<Variations> Variations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  AvailableQuantity: ").Append(AvailableQuantity).Append("\n");
            sb.Append("  BuyingMode: ").Append(BuyingMode).Append("\n");
            sb.Append("  ListingTypeId: ").Append(ListingTypeId).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VideoId: ").Append(VideoId).Append("\n");
            sb.Append("  Warranty: ").Append(Warranty).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Variations: ").Append(Variations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    this.Title.Equals(input.Title)
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    this.CategoryId.Equals(input.CategoryId)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.AvailableQuantity == input.AvailableQuantity ||
                    (this.AvailableQuantity != null &&
                    this.AvailableQuantity.Equals(input.AvailableQuantity))
                ) && 
                (
                    this.BuyingMode == input.BuyingMode ||
                    (this.BuyingMode != null &&
                    this.BuyingMode.Equals(input.BuyingMode))
                ) && 
                (
                    this.ListingTypeId == input.ListingTypeId ||
                    (this.ListingTypeId != null &&
                    this.ListingTypeId.Equals(input.ListingTypeId))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.VideoId == input.VideoId ||
                    (this.VideoId != null &&
                    this.VideoId.Equals(input.VideoId))
                ) && 
                (
                    this.Warranty == input.Warranty ||
                    (this.Warranty != null &&
                    this.Warranty.Equals(input.Warranty))
                ) && 
                (
                    this.Pictures == input.Pictures ||
                    this.Pictures != null &&
                    input.Pictures != null &&
                    this.Pictures.SequenceEqual(input.Pictures)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Variations == input.Variations ||
                    this.Variations != null &&
                    input.Variations != null &&
                    this.Variations.SequenceEqual(input.Variations)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.AvailableQuantity != null)
                    hashCode = hashCode * 59 + this.AvailableQuantity.GetHashCode();
                if (this.BuyingMode != null)
                    hashCode = hashCode * 59 + this.BuyingMode.GetHashCode();
                if (this.ListingTypeId != null)
                    hashCode = hashCode * 59 + this.ListingTypeId.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VideoId != null)
                    hashCode = hashCode * 59 + this.VideoId.GetHashCode();
                if (this.Warranty != null)
                    hashCode = hashCode * 59 + this.Warranty.GetHashCode();
                if (this.Pictures != null)
                    hashCode = hashCode * 59 + this.Pictures.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Variations != null)
                    hashCode = hashCode * 59 + this.Variations.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}