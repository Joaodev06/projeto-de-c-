import{View, Text,TextInput, StyleSheet,Button,TouchableOpacity} from 'react-native';
import React,{useState} from 'react';


import { AntDesign } from '@expo/vector-icons';
import { MaterialCommunityIcons } from '@expo/vector-icons';


export default function Atividades(){
const[valor1, setValor1]= useState('');
const[valor2, setValor2]= useState('');
const[Resultado, setResultado]= useState('');
if(valor1 === '' || valor2 === ''){
alert("Digite os dois valores");
}
const soma = () => {
const Resultado= parseFloat(valor1) + parseFloat(valor2);
setResultado(Resultado.toString());
};

const sub = () => {
const Resultado= parseFloat(valor1) - parseFloat(valor2);
setResultado(Resultado.toString());
};

const mult = () => {
const Resultado= parseFloat(valor1) * parseFloat(valor2);
setResultado(Resultado.toString());
};

const divi = () => {
const Resultado= parseFloat(valor1) / parseFloat(valor2);
setResultado(Resultado.toFixed(2));
};

    return(


<View style={styles.view1}>
<Text style={styles.txt}> Primeira calculadora em Javscript</Text>
<TextInput 
placeholder= "Digite o 1º valor: "
style={styles.input}
value={valor1}
onChangeText={text => setValor1(text)}
/>
<TextInput 
placeholder= "Digite o 2º valor: "
style={styles.input}
value={valor2}
onChangeText={text => setValor2(text)}
/>


<View style={styles.view2}>
<TouchableOpacity style={styles.touch} onPress={soma}>
<AntDesign name="plus" size={24} color="black" />
</TouchableOpacity>
<TouchableOpacity style={styles.touch} onPress={sub}>
<AntDesign name="minus" size={24} color="black" />
</TouchableOpacity>
<TouchableOpacity style={styles.touch} onPress={mult}>
<MaterialCommunityIcons name="multiplication" size={24} color="black" />
</TouchableOpacity>
<TouchableOpacity style={styles.touch} onPress={divi}>
<MaterialCommunityIcons name="division" size={24} color="black"  />
</TouchableOpacity>
<Text style={styles.txt2}>Resultado:</Text>
<Text style={styles.txt3}>{Resultado}</Text>


</View>
</View>





  );
}

const styles = StyleSheet.create({

view1:{
  backgroundColor:'cyan',
  width:"90%",
  height:100,
    justifyContent:'center',
  alignItems:'center',
    flex:1,
},
txt:{

marginBottom:'100px',
marginTop:'-80px',
fontSize:18,
},

input:{
  marginBottom:20,
  borderColor:'yellow',
  borderWidth:2,
  borderRadius:7,
  width:'60%',
  justifyContent:'center',
  alignItems:'center',

},
view2:{ width:'75%', flexDirection:'row'},
touch:
{
  backgroundColor:'purple',
  width:40,
  height:50,
  justifyContent:'center',
  alignItems:'center',
  marginLeft:10,
      marginBottom:200,
      borderRadius: 10, 
},

txt2:{
marginBottom:'100px',
marginTop:'100px',
marginLeft: '-150px',
fontSize:35,
},

txt3:{
marginBottom:'90px',
marginTop:'200px',
marginLeft: '-100px',
fontSize:35,
justifyContent:'center',
  alignItems:'center',
}
});