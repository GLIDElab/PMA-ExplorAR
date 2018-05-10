using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class JSONWriter : MonoBehaviour {

	public WorkInfo currWork;

	public Text name;
	public Text date;
	public Text artist;
	public Text label;
	public Text longitude;
	public Text latitude;
	public Text objectID;

	public string gallery111_001;
	public string gallery111_002;
	public string gallery111_003;
	public string gallery111_004;
	public string gallery111_005;
	public string gallery111_006;
	public string gallery111_007;
	public string gallery111_008;
	public string gallery111_009;
	public string gallery111_010;
	public string gallery111_011;
	public string gallery111_012;
	public string gallery111_013;
	public string gallery111_014;
	public string gallery111_015;

	public string gallery116_001;
	public string gallery116_002;
	public string gallery116_003;
	public string gallery116_004;
	public string gallery116_005;
	public string gallery116_006;
	public string gallery116_007;
	public string gallery116_008;
	public string gallery116_009;
	public string gallery116_010;
	public string gallery116_011;
	public string gallery116_012;
	public string gallery116_013;
	public string gallery116_014;
	public string gallery116_015;
	public string gallery116_016;
	public string gallery116_017;

	public string gallery155_001;
	public string gallery155_002;
	public string gallery155_003;
	public string gallery155_004;
	public string gallery155_005;
	public string gallery155_006;
	public string gallery155_007;
	public string gallery155_008;
	public string gallery155_009;
	public string gallery155_010;
	public string gallery155_011;
	public string gallery155_012;
	public string gallery155_013;
	public string gallery155_014;
	public string gallery155_015;
	public string gallery155_016;
	public string gallery155_017;
	public string gallery155_018;
	public string gallery155_019;
	public string gallery155_020;

	public string gallery161_001;
	public string gallery161_002;
	public string gallery161_003;
	public string gallery161_004;
	public string gallery161_005;
	public string gallery161_006;
	public string gallery161_007;
	public string gallery161_008;
	public string gallery161_009;
	public string gallery161_010;
	public string gallery161_011;
	public string gallery161_012;
	public string gallery161_013;
	public string gallery161_014;
	public string gallery161_015;

	public string gallery201_001;

	public string gallery204_001;
	public string gallery204_002;
	public string gallery204_003;
	public string gallery204_004;
	public string gallery204_005;

	public string gallery226_001;

	public string gallery265_001;
	public string gallery265_002;
	public string gallery265_003;
	public string gallery265_004;
	public string gallery265_005;

	[SerializeField]
	public class WorkInfo {
		public string name;
		public int date;
		public string artist;
		public string label;
		public double longitude;
		public double latitude;
		public int objectID;
	}

	public string WriteJSONFile (string name, int date, string artist, string label, double longitude, double latitude, int objectID) {
		WorkInfo currWork = new WorkInfo ();
		currWork.name = name;
		currWork.date = date;
		currWork.artist = artist;
		currWork.label = label;
		currWork.objectID = objectID;

		string json = JsonUtility.ToJson (currWork);
		return json;
	}

	public static WorkInfo ExtractJSONFile (string json) {
		return JsonUtility.FromJson<WorkInfo> (json);
	}

	public void WriteStats (WorkInfo info) {
		name.text = info.name;
		date.text = "Year: " + info.date.ToString();
		artist.text = info.artist;
		label.text = info.label;
	}

	public void WaterLilies () {
		gallery161_003 = WriteJSONFile ("The Japanese Footbridge and the Water Lily, Giverny", 1899, "Claude Monet", "(No Label)", -75.2, 39.9, 59194);
	}

	public void Gallery111 () {
		gallery111_001 = WriteJSONFile ("The Concert Singer", 1890, "Thomas Eakins", "Thomas Eakins's abrupt dismissal from the Pennsylvania Academy of the Fine Arts, Philadelphia, in 1866-- resulting from his use of nude models in classes with female students-- caused a marked change in his work. WHen he started to paint again, after a two-year period of depression, he concentrated on the penatrating portrait studies that would comprise the majority of his work until his death. His laborious procedure for exactly representing the act of singing was describe by Weda Cook, the preformer seen in this painting. SHe recalled that Eakins would have her repeatedly sing the same phrase-- from a Felix Mendelssohn composiiton-- as he watched the action of her mouth and throat. The artist carved the opening bars of that song into the frame of the picture.", -75.3, 39.9, 42499);
		gallery111_002 = WriteJSONFile ("Antiqued Music", 1900, "Thomas Eakins", "Mrs. Frishmuth (1842–1926) was a passionate collector of antique musical instruments and early American artifacts, textiles, and samplers, many of which are now in the Philadelphia Museum of Art. In 1897, she gave a large part of her collection to the museum at the University of Pennsylvania (now the University Museum). Eakins very likely hoped that his grand portrait would be acquired by the university to hang with her donation. The university did accept the painting on loan, but eventually returned it to the artist after Eakins removed it repeatedly to send to other exhibitions.", -75.3, 39.9, 42535);
		gallery111_003 = WriteJSONFile ("Breaking Home Ties", 1890, "Thomas Hovenden", "Voted the most popular painting at the Chicago World’s Columbian Exposition in 1893, Breaking Home Tiescaptured the American imagination as few other pictures have. The 1890s saw the decline of small family farms and the necessity of young sons leaving the land to make a living in the city or on what little was left of the frontier. The scene Thomas Hovenden depicts here had been enacted in many homes, and the composition gave American families a visual record of their own turmoil. The artist used models he knew well: each figure can be identified as a relative or friend of the Hovendens, including the family dog.", -75.3, 39.9, 47809);
		gallery111_004 = WriteJSONFile ("The Revenge", 1882, "George de Forest Brush", "Paintings of American Indian life were immensely popular during the late 1800s, as viewers grew curious about the exotic qualities of Native American culture and began to lament its loss. Brush constructs both a romantic and savage image of the American Indian.", -75.3, 39.9, 48675);
		gallery111_005 = WriteJSONFile ("Valley of Oaxaca", 1888, "Jose Maria Velasco", "American artists traveled to the exotic corners of their own country as well as to Europe and Asia to seek picturesque subjects. When this painting was made, the American West remained a vastly unexplored and fundamentally foreign land. The Atchison, Topeka and Santa Fe Railway hired Moran to create this monumental panorama for use in promoting tourism to the region.", -75.3, 39.9, 50796);
		gallery111_006 = WriteJSONFile ("Grand Canyon of the Colorado River", 1892, "Thomas Moran", "American artists traveled to the exotic corners of their own country as well as to Europe and Asia to seek picturesque subjects. When this painting was made, the American West remained a vastly unexplored and fundamentally foreign land. The Atchison, Topeka and Santa Fe Railway hired Moran to create this monumental panorama for use in promoting tourism to the region.", -75.3, 39.9, 70115);
		gallery111_007 = WriteJSONFile ("Spring", 1901, "John La Farge", "John La Farge was one of the first American artists to respond to Japanese art. Inspired by the flowing contours, asymmetrical compositions, and color harmonies of the East, he fused these elements with Western artistic motifs, reminiscent of renaissance painting. La Farge, who invented modern opalescent glass, called this window a “picture work in glass.”", -75.3, 39.9, 71981);
		gallery111_008 = WriteJSONFile ("Summer Landscape", 1876, "George Inness", "Travel in Europe exposed Inness to the peaceful, contemplative style of Italian landscape painting. In this work he captures the poetry of everyday life by focusing attention on the solitary cowherd and his animals. The artist uses both distance and shadow to create the feeling that one is viewing this intimate scene from beneath the shade of a nearby tree.", -75.3, 39.9, 102954);
		gallery111_009 = WriteJSONFile ("The Ruins of Fast Castle, Berwickshire, Scotland: The Wolf's Crag of the Bride of Lammermoor", 1892, "William Trost Richards", "Richards is famous for his paintings of stormy, rocky coasts, which were widely exhibited throughout the United States and England. Gloomy and dramatic, this view of ruins above a pounding sea comments on the forces of time and nature.", -75.3, 39.9, 103511);
		gallery111_010 = WriteJSONFile ("Arrangement in Black", 1883, "James Abbott McNeill", "The subject of this painting, Lady Archibald Campbell, was interested in the art of her time and posed for three full-length portraits by Whistler. This was the only one to be completed and to survive. Lady Campbell's family, however, did not share her appreciation of contemporary art and rejected the painting, claiming it represented \"a street walker encouraging a shy follower with a backward glance.\" But the work was purchased for the W. P. Wilstach Collection in 1895, making it the first Whistler painting bought for an American public collection.", -75.3, 39.9, 104367);
		gallery111_011 = WriteJSONFile ("Short Cut, Watchung Station, New Jersey", 1883, "George Inness", "In a bucolic landscape of northern New Jersey, Inness’s carefully manipulated vantage point places rural life and modern technology on a collision course. An elderly man leaning on a walking stick makes his way across a rickety bridge in the foreground, appearing to confront a train speeding in his direction in the background. The precarious position of the figure over a dark chasm conveys the artist’s sense of the vulnerability of historic tradition in the modern era, a concern that resonates with his admiration for the old masters.", -75.3, 39.9, 104371);
		gallery111_012 = WriteJSONFile ("The Annunciation", 1898, "Henry Ossawa Tanner", "Tanner painted The Annunciation soon after returning to Paris from a trip to Egypt and Palestine in 1897. The son of a minister in the African Methodist Episcopal Church, Tanner specialized in religious subjects, and wanted to experience the people, culture, architecture, and light of the Holy Land. Influenced by what he saw, Tanner created an unconventional image of the moment when the angel Gabriel announces to Mary that she will bear the Son of God. Mary is shown as an adolescent dressed in rumpled Middle Eastern peasant clothing, without a halo or other holy attributes. Gabriel appears only as a shaft of light. Tanner entered this painting in the 1898 Paris Salon exhibition, after which it was bought for the Philadelphia Museum of Art in 1899, making it his first work to enter an American museum.", -75.3, 39.9, 104384);
		gallery111_013 = WriteJSONFile ("A Woman and a Girl Driving", 1881, "Mary Stevenson Cassatt", "The modern subject matter, odd viewpoint, and blurred detail of this painting make it strikingly different from those of Cassatt’s American contemporaries. Though born and raised in Pennsylvania, Cassatt traveled to France for additional artistic training and remained there for the rest of her life. In Paris she took up the radical stylistic innovations of the Impressionists, becoming the only American invited to join their ranks.", -75.3, 39.9, 104447);
		gallery111_014 = WriteJSONFile ("Newport Castle", 1902, "William Trost Richards", "Richards spent hours studying the visual effects of water and its movement. His mastery of marine painting is demonstrated in this view of sunlit surf, which sparkles with a gemlike translucency.\n", -75.3, 39.9, 159130);
		gallery111_015 = WriteJSONFile ("A Waterfall", 1910, "John Singer Sargent", "Inspired by several trips to Italy and Switzerland, Sargent took a break from figure painting and turned to landscapes. In this image the artist captures the stream’s foaming water with thickly applied white paint. To create the effect of sunlight through rising mist, Sargent employs raw color, such as red, green, violet, and gold, recalling the paintings of his friend Claude Monet", -75.3, 39.9, 269032);
	}

	public void Gallery116 () {
		gallery116_001 = WriteJSONFile ("Second Beach, Newport", 1865, "Worthington Whittredge", "Born in Ohio, Worthington Whittredge worked in Cincinnati as a house and sign painter, a portraitist, and later a landscape painter. After ten years spent traveling and working in Europe, he returned to New York in 1859 with a crisp, naturalistic style shaped by the precision of contemporary German painting. His style gracefully adapted to American subjects and Americans’ taste for quiet, light-filled landscapes. This tranquil view of a sunrise on a beach at Newport shares the contemplative spirit and spaciousness of contemporary paintings by his colleagues in the second generation of the New York School.", -75.18, 39.97, 34120);
		gallery116_002 = WriteJSONFile ("Twilight on the Campagna", 1851, "George Inness", "Unburdened by narrative—a major shift for the young Inness—Twilight on the Campagna experiments instead with mood. The artist later declared that his primary goal was “not to instruct, not to edify, but to awaken an emotion.” The twisting, tortured trunks of the trees at right, silhouetted by the waning light, are melancholic and resonate with the dramatic scenes of Baroque master Salvator Rosa (1615–1673). Painted soon after Inness’s arrival in Italy, Twilight on the Campagna anticipates the poetic dimension that became the artist’s signature in the last decade of his life.", -75.18, 39.97, 49639);
		gallery116_003 = WriteJSONFile ("A Temperance Meeting", 1874, "Winslow Homer", "Homer's painting cleverly refers to the rising American temperance movement, a crusade against drinking alcohol, by depicting a stout milkmaid pausing while a farmhand drinks from her ladle. Swaying under the weight of her pail and squinting into the sun, she presents the ideal of natural womanhood. Her powerful presence, marked by broad shoulders, muscular arms, and sunburned skin, counters the farmhand's relaxed stance and shaded face, visually reversing traditional gender roles. Far from flirting, the two figures awkwardly avoid each other's gaze, modeling rural wholesomeness and rectitude.", -75.18, 39.97, 55686);
		gallery116_004 = WriteJSONFile ("Orchids in a Jungle", 1866, "Orchids in a Jungle", "A craze for orchids swept Europe and the United States in the mid-nineteenth century, as illustrated by this painting's lush hybrid of landscape and still life. The tropical bloom often served as an allusion to feminine sexuality for artists and writers of this era, and probably would have been read as such by Martin Johnson Heade's contemporaries.\n\nHeade began a series of orchid and hummingbird paintings after his final trip to South America in 1870, demonstrating his dedication to birds and flowers modeled from nature that he often placed in settings both evocative and fantastic. The coming storm adds a sense of foreboding to this otherwise calm scene.", -75.18, 39.97, 72177);
		gallery116_005 = WriteJSONFile ("Portrait of George", 1887, "Portrait of George Burnham", "The two sides of George Burnham (1817-1912) are expressed in this simultaneously dignified and informal portrait. An engineer who became the chief financial officer of Philadelphia's world-famous Baldwin Locomotive Works, Burnham was also a dedicated member of the First Swedenborgian Church.\n\nCecilia Beaux, the favored portrait painter of Philadelphia's elite, depicts Burnham in a somber business suit, but sitting in a stylishly rustic chair on the porch of his summer house at Lake George, New York. Against a backdrop of pines that hints at his spiritual connection to nature, he holds a book that may be one of the many church publications he sponsored.", -75.18, 39.97, 94025);
		gallery116_006 = WriteJSONFile ("A Coming Storm", 1863, "Sanford Gifford", "Painted in the midst of the Civil War, Sanford Gifford's A Coming Storm was first owned by celebrated Shakespearean actor Edwin Booth, brother of Abraham Lincoln's assassin, John Wilkes Booth. When the great American writer Herman Melville saw the painting at an exhibition in New York City just after Lincoln's death in April 1865, he was struck by the work's symbolism and wrote a poem about its tragic prescience that includes:\n\nA demon-cloud like the mountain one\nBurst on a spirit as mild\nAs this urned lake, the home of shades.\n\nGifford, who served in the Union Army himself, was keenly interested in the dramatic effects of weather and light, shown here along the banks of Lake George in upstate New York.", -75.18, 39.97, 94025);
		gallery116_007 = WriteJSONFile ("Pichincha", 1867, "Frederic Edwin Church", "Church became famous for his paintings of natural wonders like Niagara Falls, icebergs in the Arctic, and volcanoes in South America. He sketched this volcano, called Pichincha, on a trip to Ecuador in 1857, but made the painting ten years later in the comfort of his studio in New York. In the finished work, Church added palm trees that could not have grown on the high Andean plain. Although the volcano is dormant in the picture, its eruptions were frequent and dangerous. It had also been the site of a fierce battle in 1822 between Ecuadorian patriots (fighting for independence) and royalists (loyal to Spain), after which the country was plunged into uncertainty and sectionalism, much like the post-Civil War United States was facing at the time Church made this painting.", -75.18, 39.97, 95643);
		gallery116_008 = WriteJSONFile ("Winter Coast", 1890, "Winslow Homer", "Homer’s tiny hunter, carrying a goose on his back, is dwarfed by the massive shelving rocks and pounding surf of Prout’s Neck, Maine. Like the increasingly solitary artist, the human figure appears alone, hardy, and ephemeral.", -75.18, 39.97, 101687);
		gallery116_009 = WriteJSONFile ("A Huntsman and Dogs", 1891, "Winslow Homer", "Renowned artist Winslow Homer was an avid sportsman and his outdoor subjects reflect an unsentimental view of the conflict between man and nature. In this scene set in the Adirondack region of New York State, earthen colors link the hunter and the environment, making it difficult to distinguish the man from the hill behind him. Homer visited the Adirondacks as one of many vacationers who flocked there in the late nineteenth century. The huntsman in Homer’s painting is not a visitor but rather a local trapper or guide who has caught a deer and is carrying off its pelt, antlers, and, likely, a pack full of meat.", -75.18, 39.97, 102943);
		gallery116_010 = WriteJSONFile ("Making a Train", 1867, "Seymour Joseph Guy", "Alone in an attic, a little girl dreams of turning her everyday clothing into something grown-up and magnificent—perhaps a ball gown or wedding dress. Seymour Guy's daughter Anna was likely the model for this painting. The warm, soft glow of an oil lamp evokes the innocence of her childhood. At the same time, shadows fall across her torso to hint at her imminent transformation into a young woman, and a doll lies abandoned in the cabinet to her right to suggest that soon such playthings will be forgotten. After the Civil War (1861-65), nostalgic visions of childhood like this one gained enormous popularity.", -75.18, 39.97, 102969);
		gallery116_011 = WriteJSONFile ("Portrait of the Artist's Mother", 1897, "Henry Ossawa Tanner", "(No Label)", -75.18, 39.97, 103024);
		gallery116_012 = WriteJSONFile ("Doorway in Tangier", 1912, "Henry Ossawa Tanner", "This vivid sketch was most likely painted in the spring of 1912, when Tanner spent three months in Tangier, Morocco. He made numerous small oil sketches that he brought back to his studio in France, where he developed them into larger paintings on canvas. These Moroccan street scenes, such as the one seen here, represent a departure from Tanner's usual focus on religious subjects and demonstrate his growing interest in bright color harmonies and richly textured and luminous layers of paint.", -75.18, 39.97, 284198);
		gallery116_013 = WriteJSONFile ("An Old Fireplace", 1882, "Charles Frederic Ulrich", "Charles Frederic Ulrich enjoyed an impressive reputation during the mid-1880s that was largely based on his small-scale genre scenes, including this one. An Old Fire-Place is believed to depict Ephrata Cloister, a historic German Anabaptist hermitage located west of Philadelphia that was founded in 1732. Ulrich's ascetic interior reflects the long history of Ephrata---reinforced by the sitter's old age and modest dress---but clearly represents life there during his own time with its original hearth converted into a simple kitchen.", -75.18, 39.97, 302126);
		gallery116_014 = WriteJSONFile ("Young Recruits", 1855, "Christian Schuessele", "In this painting, a Revolutionary War officer cheerfully rallies a group of boys wearing comical hats and armed with toy weapons. But not every face in this painting is joyful. For Christian Schuessele, who left revolution-torn Europe in 1848, the lessons of the successful American War of Independence (1775-83) were hardly playful or childish matters. By 1855, when the artist painted this scene, the United States was again struggling, this time to remain a union. In an era when artists rarely addressed political tensions, The Young Recruits raised questions about patriotism and readiness for war, bringing national issues into the realm of the family and the neighborhood.", -75.18, 39.97, 306773);
		gallery116_015 = WriteJSONFile ("Dana Beach, Manchester", 1860, "Fitz Henry Lane", "Fitz Henry Lane’s luminous views of beaches and harbors from Massachusetts to Maine have long been considered some of the finest achievements in nineteenth-century American landscape painting. His works’ signature serenity has been identified as an artistic corollary to the roughly contemporary development of Transcendentalist philosophy and Unitarian faith in the Boston area. In recent years, Lane’s relationship with his gifted student and collaborator Mary Blood Mellen has come to light, altering the attributions of numerous works once securely identified as Lane’s.", -75.18, 39.97, 307378);
		gallery116_016 = WriteJSONFile ("Flower Still Life with Bird's Nest", 1853, "Severin Roesen", "Severin Roesen's lavish tabletop array is crowded with blooms from all seasons--topped by a crown imperial and including lilacs, poppies, daylilies, tulips, irises, roses, morning glories, and nasturtiums, among others--and reflects the mid-nineteenth-century American taste for scenes of natural bounty. Strong, dense flower forms at the brightly lit center balance with more sinuous, silhouetted stems that reach outward to the edges of the composition.\n\nRoesen simultaneously elevated still life painting in America and charted a new direction for its practice. He spent much of his career working for local patrons in Williamsport, Pennsylvania, northwest of Philadelphia, but his influence extended across the country.", -75.18, 39.97, 308014);
		gallery116_017 = WriteJSONFile ("South American Sunset", 1873, "Norton Bush", "(No Label)", -75.18, 39.97, 320528);
	}

	public void Gallery155 () {
		gallery155_001 = WriteJSONFile ("The Crucifixion", 1880, "Thomas Eakins", "This painting of the Crucifixion, Eakins's only religious work, demonstrates the artist's interest in rendering the human body realistically. Jesus's sagging torso, bent knees, stretched arms, and clenched hands all suggest an actual male body hanging from a cross in the agony of his last moments. To understand the human anatomy in this position, Eakins strapped a model, one of his students, to a cross.\n\nEakins spent most of his life in Philadelphia, but trained in a Paris studio where the study of the nude was considered an esse", -75.18, 39.96, 42505);
		gallery155_002 = WriteJSONFile ("Portrait of a Roman Lady", 1859, "Sir Frederic Leighton", "(No Label)", -75.18, 39.96, 70918);
		gallery155_003 = WriteJSONFile ("The Bridge at Loosduinen", 1872, "Jacob Hendricus Maris", "(No Label)", -75.18, 39.96, 101711);
		gallery155_004 = WriteJSONFile ("River and Towpath", 1883, "Alfred Parsons", "(No Label)", -75.18, 39.96, 101735);
		gallery155_005 = WriteJSONFile ("In the Luxembourg Gardens", 1879, "John Singer Sargent", "(No Label)", -75.18, 39.96, 101764);
		gallery155_006 = WriteJSONFile ("Leashed Hounds", 1860, "Constant Troyon", "As part of his training as a hunting dog, a young hound is leashed to an older one so that he may learn to follow a scent. Constant Troyon's animal pictures were influenced by the seventeenth-century Dutch paintings that he saw on a trip to Holland in 1847.", -75.18, 39.96, 101789);
		gallery155_007 = WriteJSONFile ("Monkey in a Studio", 1869, "Atoine Vollon", "In this study of an artist's studio, Vollon creates an allegory of the liberal arts. The score and trumpet represent music, the books philosophy, the canvas on the easel painting, and the various works scattered throughout the studio sculpture. At the rear are casts from Michelangelo's Medici tombs in Florence, and of Minerva, the Roman goddess of the arts. In depicting a monkey as an artist, Vollon evokes a seventeenth-century Dutch tradition of satirizing the artist as imitator of nature, or \"art as the ape of nature.\"", -75.18, 39.96, 101795);
		gallery155_008 = WriteJSONFile ("Purple and Rose: The Lange Leizen of the Six Marks", 1864, "James Abbott McNeill Whistler", "Lange Leizen, which is the Dutch term for \"Long Ladies,\" is the name applied to blue-and-white Chinese porcelain decorated with images of slender women. Whistler's interest in East Asian art can be seen here in the accessories surrounding the model, many of which are based on his own art collection.", -75.18, 39.96, 101800);
		gallery155_009 = WriteJSONFile ("The Feast of Saint John", 1875, "Jules-Adolphe-Aime-Louis Breton", "Since ancient times, peasants have celebrated the longest days of summer with festivities. This dance around a fire marks the feast of Saint John the Baptist on June 24, an important occasion in France.", -75.18, 39.96, 102740);
		gallery155_010 = WriteJSONFile ("The Moorish Chief", 1878, "Eduard Charlemont", "Standing in front of an arch that closely resembles the architecture of the Alhambra in Spain, the Moorish chief exudes power and mystery. This painting was probably shown at the Paris Salon exhibition of 1878 with the title Le Gardien du serail (The Harem Guard).\n\nCharlemont was a Viennese artist known primarily for his nudes and portraits. While this subject was unusual for him, it was very popular in Europe at the time.", -75.18, 39.96, 102792);
		gallery155_011 = WriteJSONFile ("Arab Chief", 1874, "Mariano Fortuny y Carbo", "(No Label)", -75.18, 39.96, 102835);
		gallery155_012 = WriteJSONFile ("Mill", 1857, "Charles-Francois Daubigny", "(No Label)", -75.18, 39.96, 102899);
		gallery155_013 = WriteJSONFile ("Faust and Marguerite", 1856, "Hendrik Jan August Leys", "This painting shows a moment in Goethe's dramatic poem Faust.\n\nFaust stands with the demonic Mephistopheles behind an iron screen, and he first spies the chaste Marguerite emerging from a church. Faust demands that Mephistopheles secure Marguerite's love for him. Leys has followed Goethe's description in his depiction of Marguerite as a young woman of modest or lower social standing with red lips, glowing cheeks, and downcast eyes.\n\nLike many nineteenth-century artists, Leys was interested in the Middle Ages. Here he dresses the characters in medieval costume and sets the scene at a medieval cathedral in Antwerp, Belgium.", -75.18, 39.96, 102947);
		gallery155_014 = WriteJSONFile ("Oak", 1895, "Henri-Joseph Harpignies", "(No Label)", -75.18, 39.96, 102964);
		gallery155_015 = WriteJSONFile ("A Reading from Homer", 1885, "Sir Lawerence Alma-Tadema", "Here, a young poet crowned with a laurel wreath reads from Homer to an audience dressed for a festival. The setting is probably Greece toward the end of the seventh century BCE. The Greek letters in the upper right indicate that the place is dedicated to the poet.\n\nThrough attention to details such as architecture and dress, Alma-Tadema evokes scenes of everyday life in ancient Greece and Rome. However, his pictures are rarely entirely archaeologically accurate. For example, while he accurately rendered the ancient musical instrument on the left, a cithara, he also included a type of rose that did not exist before the nineteenth century.", -75.18, 39.96, 102964);
		gallery155_016 = WriteJSONFile ("Highway of Combes-la-Ville", 1873, "Giovanni Boldini", "(No Label)", -75.18, 39.96, 102975);
		gallery155_017 = WriteJSONFile ("The Return of the Flock", 1886, "Aton Mauve", "(No Label)", -75.18, 39.96, 102977);
		gallery155_018 = WriteJSONFile ("Morning", 1884, "Louis-Joseph-Raphael Collin", "(No Label)", -75.18, 39.96, 103674);
		gallery155_019 = WriteJSONFile ("Peace and War", 1867, "Pierre Puvis de Chavannes", "(No Label)", -75.18, 39.96, 137454);
		gallery155_020 = WriteJSONFile ("Study of Three Heads, Studies of Black Men", 1870, "Henri-Georges-Alexandre Regnault", "(No Label)", -75.18, 39.96, 300187);
	}

	public void Gallery161 () {
		gallery161_001 = WriteJSONFile ("The Bridge over the River Touques", 1894, "Eugene-Louis Boudin", "(No Label)", -75.2, 39.9, 59192);
		gallery161_002 = WriteJSONFile ("The Folkstone Boat, Boulogne", 1869, "Edouard Manet", "This image of the steam ferry that carried passengers from Boulogne to Folkestone, on the Channel coast in England, is one of two paintings that Manet made of the subject. The painting conveys the bustle and excitement of international travel in the early days of the steamboat's operation. Manet employed thick and sometimes choppy brushstrokes to provide a sense of the enormous visual interest the scene held for him. His signature on this painting indicates that he considered it complete, despite its lack of incidental detail.", -75.2, 39.9, 59193);
		gallery161_003 = WriteJSONFile ("The Japanese Footbridge and the Water Lily, Giverny", 1899, "Claude Monet", "(No Label)", -75.2, 39.9, 59194);
		gallery161_004 = WriteJSONFile ("Boy with a Toy Soldier", 1875, "Pierre-Auguste Renoir", "(No Label)", -75.2, 39.9, 59197);
		gallery161_005 = WriteJSONFile ("Two Girls", 1892, "Pierre-Auguste Renoir", "(No Label)", -75.2, 39.9, 59198);
		gallery161_006 = WriteJSONFile ("Still Life with Flowers and Fruit", 1890, "Pierre-Auguste Renoir", "(No Label)", -75.2, 39.9, 59199);
		gallery161_007 = WriteJSONFile ("Portrait of Alfred Berard with His Dog", 1881, "Pierre-Auguste Renoir", "(No Label)", -75.2, 39.9, 59200);
		gallery161_008 = WriteJSONFile ("The Canal at Saint-Mammes", 1885, "Alfred Sisley", "(No Label)", -75.2, 39.9, 59201);
		gallery161_009 = WriteJSONFile ("Sunflowers", 1888, "Vincent Willem van Gogh", "(No Label)", -75.2, 39.9, 59202);
		gallery161_010 = WriteJSONFile ("Still Life with Flowers in an Olive Jar", 1880, "Paul Cezanne", "(No Label)", -75.2, 39.9, 59203);
		gallery161_011 = WriteJSONFile ("Bay of L'Estaque", 1879, "Paul Cezanne", "(No Label)", -75.2, 39.9, 59205);
		gallery161_012 = WriteJSONFile ("View of the Bay of Marseille with the Village of Saint-Henri", 1883, "Paul Cezanne", "(No Label)", -75.2, 39.9, 59207);
		gallery161_013 = WriteJSONFile ("Milestone in the Park of the Chateau Noir", 1898, "Paul Cezanne", "(No Label)", -75.2, 39.9, 59208);
		gallery161_014 = WriteJSONFile ("Still Life with a Dessert", 1877, "Paul Cezanne", "(No Label)", -75.2, 39.9, 59209);
		gallery161_015 = WriteJSONFile ("Le Bron Bock", 1873, "Edouard Manet", "Bock is a dark, rich beer made in the spring. This vivid depiction of a drinker recalls the animated portraits by seventeenth-century Dutch masters like Frans Hals that Manet greatly admired.", -75.2, 39.9, 59213);
	}

	public void Gallery201 () {
		gallery201_001 = WriteJSONFile ("Crucifix", 1285, "Master of Montelabate", "In the 1200s, the Franciscans popularized the use of large, painted crucifixes like this one, which were often mounted on rood screens that divided the nave from the sanctuary of a church. Though the dying Christ's figure follows the model of a famous crucifix then in the Franciscan's principal church in Assisi, this painting was not made for a Franciscan church, but probably for the church of a nearby monastery of another religious order. At Christ's feet kneels the donor who ordered the painting. He does not wear a Franciscan friar's simple tunic, but the rich robes of an abbot.", -75.18, 39.97, 104472);
	}

	public void Gallery204 () {
		gallery201_001 = WriteJSONFile ("Plaque with Symbol", 1250, "Unknown", "(No Label)", -75.18, 39.97, 145295);
		gallery204_002 = WriteJSONFile ("Plaque with Symbol of Saint Luke", 1250, "Unknown", "(No Label)", -75.18, 39.97, 145298);
		gallery204_003 = WriteJSONFile ("Plaque with Symbol of Saint Matthew", 1250, "Unknown", "(No Label)", -75.18, 39.97, 145300);
		gallery204_004 = WriteJSONFile ("Plaque with Symbol of Saint Mark", 1250, "Unknown", "(No Label)", -75.18, 39.97, 145301);
		gallery204_005 = WriteJSONFile ("Decorative Relief", 1250, "Unknown", "(No Label)", -75.18, 39.97, 145302);
	}

	public void Gallery226 () {
		gallery226_001 = WriteJSONFile ("Fish", 1368, "Unknown", "(No Label)", -75.18, 39.97, 41625);
	}

	public void Gallery244 () {
		
	}

	public void Gallery265 () {
		gallery265_001 = WriteJSONFile ("Carpet", 1668, "Savonnerie Carpet Manufactory", "", -75.18, 39.97, 45794);
		gallery265_002 = WriteJSONFile ("La Toilette de Psyche", 1741, "Francois Boucher", "", -75.18, 39.97, 45799);
		gallery265_003 = WriteJSONFile ("L'Abandon de Psyche", 1742, "Francois Boucher", "", -75.18, 39.97, 45801);
		gallery265_004 = WriteJSONFile ("Psyche et le Vannier", 1741, "Francois Boucher", "", -75.18, 39.97, 45802);
		gallery265_005 = WriteJSONFile ("Psyche et le Vannier", 1743, "Francois Boucher", "", -75.18, 39.97, 45803);
	}



	void Start() {
		Gallery111 ();
		Gallery116 ();
		Gallery155 ();
		Gallery161 ();
		Gallery201 ();
		Gallery204 ();
		Gallery226 ();
		Gallery244 ();
		Gallery265 ();
	}


}
