import { Text, SafeAreaView, StyleSheet, View, TextInput, TouchableOpacity, FlatList } from 'react-native';
import { Entypo } from '@expo/vector-icons';
import React, { useState } from 'react';
import Index from './Index';

export default function App() {
  const [tarefa, setTarefa] = useState('');
  const [nome, setName] = useState([]);



 function adicionarItem() {
    if (tarefa. trim() === '') {
      alert("Digite algum valor");
      return;
    }

    const dados = {
      key: Date.now(),
      item: tarefa
    };

    setName(pegarItens => [dados, ...pegarItens]);
   setTarefa('');
  }

function deletarIteN(item){
if (confirm("Deseja realmente excluir este item?") ==true)
{
var passarLista = nome.filter((tarefa)=>{
    return (tarefa.item !==item)
  
   })
  setName(passarLista)
}
  
}
  return (
    <View style={styles.view1}>
      <Text style={styles.text}>Digite Algo</Text>
      <View style={styles.view2}>
        <TextInput
          style={styles.txt}
          placeholder="Digite um item"
          value={tarefa}
          onChangeText={setTarefa}
        />
        <TouchableOpacity style={styles.touch} onPress={adicionarItem}>
          <Entypo name="plus" size={24} color="black" />
        </TouchableOpacity>
      </View>
      <FlatList
        data={nome}
        keyExtractor={item => item.key}
        renderItem={({ item }) => <Index data={item} deletar={()=>deletarIteN(item.item)} />}
        style={styles.list}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  view1: { backgroundColor: "#8A2BE2", flex: 1, alignContent: 'center', padding: 10 },
  txt: { marginTop: 13, backgroundColor: 'cyan', width: 210, borderRadius: 2, height: 50, alignItems: 'center', justifyContent: 'center', fontStyle: 'italic', fontSize: 25 },
  touch: { marginLeft: 220, marginTop: -49, backgroundColor: 'yellow', alignItems: 'center', justifyContent: 'center', height: 48, width: 45 },
  text: { marginTop: 9, fontWeight: 'bold', fontSize: 24 },
  list: { backgroundColor: 'white', flex: 1, alignContent: 'center', marginTop: 10 },
});
